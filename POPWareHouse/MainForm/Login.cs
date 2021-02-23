
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using VO;

namespace POPWareHouse.MainForm
{
    public partial class LogIn : Form
    {
        string Id;
        Process pro;
        HttpClient client;
        public LogIn()
        {
            InitializeComponent();
        }
        
        private void LogIn_Load(object sender, EventArgs e)
        {
            string server = @"C:\FP\Final_POP\POP\POPWareHouse\bin\Barcode.exe";
            pro = Process.Start(server, $"{"127.0.0.1"} {"8800"}");


        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/Employees/" + textBox1.Text.Trim();
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<EmployeesVO> apiMessage = jss.Deserialize<ApiMessage<EmployeesVO>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    Global.Global.employees = apiMessage.Data;

                    this.Hide();
                    MDI.MDIForm MDI = new MDI.MDIForm();
                    this.OpenCreateForm(MDI);
                }
                else
                {
                    MessageBox.Show("검색된 직원 정보가 없습니다.");
                }
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pro.HasExited)
            {
                pro.Kill();
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
