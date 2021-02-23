using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace POPWareHouse
{
    /// <summary>
    /// TcpClient 연결및 송수신을 담당하는 클래스 (별도의 쓰레드로 작동할 예정)
    /// </summary>
    public class ThreadPLCTask
    {
        public delegate void ReacDataEventHandle(object sender, ReadDataEventArgs args);
        public event ReacDataEventHandle ReadData;
        public bool Connection { get { return m_ConnectionSts; } }

        //Reset()을 호출하여 문을 닫고 이후에 도착한 쓰레들을 다시 대기토록 한다.
        ManualResetEvent m_ThreadTerminateRequest = new ManualResetEvent(false);
        Thread m_Thread;
        bool m_ConnectionSts = false;

        TcpControl client;
        NetworkStream recvData;
        SqlConnection conn;

        string hostIP;
        int hostPort;
        int taskID;
        string clientName;
        string clientIP;
        int timer_CONNECT = 1000;
        int timer_KEEP_ALIVE = 5000;
        int timer_READ_PLC = 300;

        Stopwatch m_AliveTimer = new Stopwatch();
        const string STR_HEART_BEAT = "HeartBeat";

        public ThreadPLCTask(int taskID, string hostIP, int hostPort, int timer_CONNECT, int timer_KEEP_ALIVE, int timer_READ_PLC, string clientName, string clientIP)
        {
            this.taskID = taskID;
            this.hostIP = hostIP;
            this.hostPort = hostPort;
            this.timer_CONNECT = timer_CONNECT;
            this.timer_KEEP_ALIVE = timer_KEEP_ALIVE;
            this.timer_READ_PLC = timer_READ_PLC;
            this.clientName = clientName;
            this.clientIP = clientIP;

            m_AliveTimer.Stop();
        }

        public void ThreadStart()
        {
            m_ThreadTerminateRequest.Reset();

            m_Thread = new Thread(ExecuteThreadJob);
            m_Thread.Start();
        }

        public void ThreadStop()
        {
            if (client == null || client.client == null) return;

            lock (m_Thread)
            {
                client.client.Close();
                m_ThreadTerminateRequest.Set();
            }
        }

        private void ExecuteThreadJob()
        {
            while (!this.m_ThreadTerminateRequest.WaitOne(timer_READ_PLC))
            {
                try
                {
                    lock (m_Thread)
                    {
                        // 실제 Thread에 필요한 코드 수행                        
                        DoingSchedule();
                    }
                }
                catch
                {

                }
            }
        }

        private void DoingSchedule()
        {
            if (!m_ConnectionSts)
            {
                //연결
                client = new TcpControl(hostIP, hostPort);
                if (client.client.Connected)
                {
                    recvData = client.dataStream;
                    m_ConnectionSts = true;
                    m_AliveTimer.Restart();

                }
            }
            else
            {
                //Alive 체크
                if (!m_AliveTimer.IsRunning || m_AliveTimer.Elapsed.TotalMilliseconds > timer_KEEP_ALIVE)
                {
                    if (!m_AliveTimer.IsRunning)
                        m_AliveTimer.Restart();

                    m_ConnectionSts = false;
                    client.client.Close();
                    client = new TcpControl(hostIP, hostPort);
                    if (client.client.Connected)
                    {
                        recvData = client.dataStream;
                        m_ConnectionSts = true;
                        m_AliveTimer.Restart();
                    }
                }

                //수신 (실제 생산실적데이터)
                OnReceive();
            }
        }

        private void OnReceive()
        {
            //STX(start of text, 0x02, 아스키 2번)
            //ETX(end of text,  0x03, 아스키 3번)
            //STX머신ID/제품ID/생산수량/불량수량ETXSTX머신ID/제품ID/생산수량/불량수량ETX
            //50|2|1   50|2|0   HeartBeat 

            bool bFind = false;
            int sCnt = 0, eCnt = 0, vLoop = 0;
            string readData = "";

            if (client.client.Available > 0)
            {
                byte[] rcvTmp = new byte[client.client.Available]; //초기 받는
                byte[] rcvValue = new byte[client.client.Available];

                recvData.Read(rcvTmp, 0, rcvTmp.Length);

                for (sCnt = 0; sCnt < rcvTmp.Length; sCnt++)
                {
                    bFind = false;
                    if (rcvTmp[sCnt] == 0x2)
                    {
                        vLoop = 0;
                        for (eCnt = sCnt + 1; eCnt < rcvTmp.Length; eCnt++)
                        {
                            if (rcvTmp[eCnt] == 0x3)
                            {
                                bFind = true;
                                break;
                            }
                            rcvValue[vLoop] = rcvTmp[eCnt];
                            vLoop++;
                        }

                        if (bFind)
                            break;
                    }
                }

                if (bFind)  //STX, ETX를 찾은 경우
                {
                    //널문자를 공백(space)로 바꿔서 배열을 채워둔다.
                    for (int i = 0; i < rcvValue.Length; i++)
                    {
                        if (rcvValue[i] == 0x0)
                            rcvValue[i] = 0x20;
                    }
                    readData = UTF7Encoding.UTF7.GetString(rcvValue).Replace(" ", "");


                    //HeartBeat 인 경우는 stopwatch만 재시작하고 빠져나간다.
                    if (readData.Contains(STR_HEART_BEAT))
                    {
                        m_AliveTimer.Restart();
                        readData = readData.Replace(STR_HEART_BEAT, "");
                    }

                    readData = readData.Trim();
                    if (readData.Length < 1) return;

                    if (ReadData != null)
                    {
                        ReadDataEventArgs args = new ReadDataEventArgs();
                        args.Data = readData;
                        ReadData(null, args);
                    }

                    string[] arrData = readData.Split('|');
                    if (arrData.Length == 3)
                    {

                    }
                }
            }
        }
    }

    public class ReadDataEventArgs : EventArgs
    {
        public string Data { get; set; }
    }
}
