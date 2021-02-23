using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using VO;

namespace POPDisplay.MainForm
{
    public partial class LogIn : Form
    {
        HttpClient client;
        private static readonly ILog log = LogManager.GetLogger(typeof(LogIn));
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            lbl_ID.BackColor = Color.FromArgb(255, 221, 85);
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/Employees/" + txt_ID.Text;
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<EmployeesVO> apiMessage = jss.Deserialize<ApiMessage<EmployeesVO>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    Global.Global.employees = apiMessage.Data;
                    UrlApi = Global.Global.APIAddress + "/TeamInfo/Emp/" + txt_ID.Text;
                    rm = await client.GetAsync(UrlApi);

                    if (rm.IsSuccessStatusCode)
                    {
                        result = await rm.Content.ReadAsStringAsync();
                        jss = new JavaScriptSerializer();
                        ApiMessage<List<TeamInfoVO>> Message = jss.Deserialize<ApiMessage<List<TeamInfoVO>>>(result);


                        if (Message.ResultCode == "S")
                        {
                            Global.Global.TeamInfos = Message.Data;
                            this.Hide();
                            MDI.MDIForm MDI = new MDI.MDIForm();
                            this.OpenCreateForm(MDI);
                        }
                        else
                        {
                            MessageBox.Show("해당 직원의 검색된 팀이 없습니다.");
                            lbl_ID.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("팀 직원 정보 검색중 실패");
                        lbl_ID.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("검색된 직원 정보가 없습니다.");
                    lbl_ID.Text = string.Empty;
                }
            }
        }
    }
}
