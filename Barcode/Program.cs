using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Barcode
{
    class Program
    {
        static List<SerialPort> PORTS = new List<SerialPort>();
        private static System.Timers.Timer aTimer;

        //private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        //{
        //    this.Invoke(new SerialDataReceivedEventHandler(MySerialReceived), sender, e);
        //}

        private static void MySerialReceived(object s, System.IO.Ports.SerialDataReceivedEventArgs e)      //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            SerialPort port = (SerialPort)s;

            string text = string.Empty;
            while (port.BytesToRead > 0)
            {
                Thread.Sleep(100);
                string ReceiveData = port.ReadExisting();                                           //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
                text += ReceiveData;                                                                //int 형식을 string형식으로 변환하여 출력
            }
            SendKeys.SendWait(text);
        }
        private static void ScannerTest_Load(object sender, ElapsedEventArgs e)
        {
            string[] stirngs = SerialPort.GetPortNames();

            if (stirngs.Length > 0)
            {
                foreach (string name in stirngs)
                {
                    try
                    {
                        SerialPort serialPort = new SerialPort();
                        serialPort.PortName = name;
                        serialPort.BaudRate = 9600;  //보레이트 변경이 필요하면 숫자 변경하기
                        serialPort.DataBits = 8;
                        serialPort.StopBits = StopBits.One;
                        serialPort.Parity = Parity.None;
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(MySerialReceived); //이것이 꼭 필요하다

                        if (!(serialPort.IsOpen && serialPort.PortName != "COM01" && serialPort.PortName != "COM02"))
                        {
                            serialPort.Open();
                            if (serialPort.IsOpen)
                            {
                                PORTS.Add(serialPort);
                            }
                        }

                        foreach(var pot in PORTS)
                        {
                            if (!pot.IsOpen)
                            {
                                pot.Close();
                                PORTS.Remove(pot);
                            }
                        }
                    }
                    catch (Exception err)
                    {

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            SetTimer();

            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += ScannerTest_Load;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    }
}
