using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VO;

namespace POPDisplay.ControlUser
{
    public partial class ProcessInfo : UserControl
    {
        double TotTactTime = 0;
        public Color FrmBack { get { return this.BackColor; } set { this.BackColor = value; } }
        FacilityVO vo;
        public int WO_EstimatedQuantity { get { return pgb_Per.Maximum ; } set { pgb_Per.Maximum = value; } }
        
        string hostIP = "127.0.0.1";
        int hostPort = 8800;
        int taskID = 1;
        string pgmID;
        string clientName;
        string clientIP;
        List<Label> labels;
        

        public ThreadPLCTask m_thread;
        int timer_CONNECT = 1000;
        int timer_KEEP_ALIVE = 5000;
        int timer_READ_PLC = 300;

        int Count = 0;

        int process_id = 0;
        Process pro;
        public ProcessInfo(FacilityVO vo)
        {
            InitializeComponent();
            this.vo = vo;
            lbl_PcsName.Text = vo.Fac_Code;
            lbl_Per.Text = vo.Fac_Name;
        }

        private void ProcessInfo_Load(object sender, EventArgs e)
        {
            pic_PcsImg.ImageLocation = "http://final6.azurewebsites.net/Images/" + vo.Fac_ImgPath;


            clientName = Dns.GetHostName();

            IPAddress[] locals = Dns.GetHostAddresses(clientName);
            if (locals.Length > 0)
            {
                clientIP = locals[1].ToString();
            }

            labels = (List<Label>)this.Tag;
        }

        public void StartThread()
        {
            try
            {
                m_thread = new ThreadPLCTask(taskID, hostIP, hostPort, timer_CONNECT, timer_KEEP_ALIVE, timer_READ_PLC, clientName, clientIP);
                m_thread.ReadData += M_thread_ReadData;
                m_thread.ThreadStart();

                timer_Connect1.Start();



                string server = @"C:\FP\Final_POP\POP\POPDisplay\bin\OutputTcpServer.exe";
                pro = Process.Start(server, $"{"127.0.0.1"} {"8800"}");
                process_id = pro.Id;
            }
            catch
            {

            }
        }

        public void StopThread()
        {
            if (!pro.HasExited)
            {
                pro.Kill();
            }
            m_thread.ThreadStop();
            timer_Connect1.Stop();

            //if (this.BackColor != Color.LightPink)
            //    this.BackColor = Color.White;
        }

        private void M_thread_ReadData(object sender, ReadDataEventArgs args)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                string data = args.Data;
                string[] vs = data.Split('|');
                int good = Convert.ToInt32(vs[0]);
                int bad = Convert.ToInt32(vs[1]);
                Count = good + bad;
                pgb_Per.Value = pgb_Per.Value + Count > pgb_Per.Maximum  ? pgb_Per.Maximum : pgb_Per.Value + Count;
                good = Convert.ToInt32(labels[0].Text) + good;
                bad = Convert.ToInt32(labels[1].Text) + bad;
                labels[0].Text = good.ToString();
                labels[1].Text = bad.ToString();
                if(WO_EstimatedQuantity <= (good + bad))
                {
                    StopThread();
                    this.BackColor = Color.LightPink;
                }
            }));
            //this.Invoke((MethodInvoker)(() => listBox1.Items.Add($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {args.Data}")));
            //this.Invoke((MethodInvoker)(() => listBox1.SelectedIndex = listBox1.Items.Count - 1));
            //this.Invoke((MethodInvoker)(() => txtReadPLC.Text = args.Data));
        }

        private void timer_Connect_Tick(object sender, EventArgs e)
        {
            try
            {
                if (m_thread.Connection)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
            catch (Exception err)
            {
               
            }
        }
    }
}
