using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net;
using log4net.Core;

namespace POPDisplay.MainForm
{
    public partial class frmPLCTask : Form
    {
        TcpControl client;
        NetworkStream recvData;

        string hostIP;
        int hostPort;
        int taskID = 1;
        string pgmID;

        bool logVisible = false;
        string clientName;
        string clientIP;

        public bool bExit = false;

        ThreadPLCTask m_thread;
        int timer_CONNECT = 1000;
        int timer_KEEP_ALIVE = 1000;
        int timer_READ_PLC = 1000;

        public frmPLCTask(string Fac_Name, string ip, string port)
        {
            InitializeComponent();

            hostIP = ip;
            hostPort = int.Parse(port);
            taskID = taskID;
            pgmID = Fac_Name;

            timer_CONNECT = timer_Connect.Interval = int.Parse(ConfigurationManager.AppSettings["timer_Connect"]);
            timer_KEEP_ALIVE = int.Parse(ConfigurationManager.AppSettings["timer_KeepAlive"]);
            timer_READ_PLC = int.Parse(ConfigurationManager.AppSettings["timer_R_PLC"]);

            lblIP.Text = hostIP;
            lblPort.Text = hostPort.ToString();
            this.Text = lblTitle.Text = taskID.ToString();

            Assembly assembly = Assembly.GetExecutingAssembly();
            lblVersion.Text = File.GetLastWriteTime(assembly.Location).ToString("yyyy.MM.dd");

            clientName = Dns.GetHostName();

            IPAddress[] locals = Dns.GetHostAddresses(clientName);
            if (locals.Length > 0)
            {
                clientIP = locals[1].ToString();
            }
        }

        private void frmPLCTask_Load(object sender, EventArgs e)
        {
            m_thread = new ThreadPLCTask(taskID, hostIP, hostPort, timer_CONNECT, timer_KEEP_ALIVE, timer_READ_PLC, clientName, clientIP);
            m_thread.ReadData += M_thread_ReadData;
            m_thread.ThreadStart();

            timer_Connect.Start();
        }

        /// <summary>
        /// 데이터를 수신받았을때 UI 컨트롤에 데이터 표현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void M_thread_ReadData(object sender, ReadDataEventArgs args)
        {
            if (logVisible)
            {
                if (listBox1.Items.Count > 50)
                    listBox1.Items.Clear();

                this.Invoke((MethodInvoker)(() => listBox1.Items.Add($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {args.Data}")));
                this.Invoke((MethodInvoker)(() => listBox1.SelectedIndex = listBox1.Items.Count - 1));
            }

            this.Invoke((MethodInvoker)(() => txtReadPLC.Text = args.Data));
        }

        private void frmPLCTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (this.Height == 145)
                {
                    this.Height = 400;
                    logVisible = true;
                }
                else
                {
                    this.Height = 145;
                    logVisible = false;
                }
            }
        }

        /// <summary>
        /// 기계와의 연결상태에 따라서 UI 컨트롤에 표시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Connect_Tick(object sender, EventArgs e)
        {
            try
            {
                if (m_thread.Connection)
                {
                    lblState.BackColor = Color.Green;
                }
                else
                {
                    lblState.BackColor = Color.Red;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
            }
        }

        private void frmPLCTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bExit)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void frmPLCTask_FormClosed(object sender, FormClosedEventArgs e)
        {

            //소켓 종료
            m_thread.ThreadStop();
        }
    }
}
