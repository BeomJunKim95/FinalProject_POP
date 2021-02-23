using POPDisplay.MDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using VO;

namespace POPDisplay.MainForm
{
    public partial class WorkRecordPopUp : POPDisplay.BaseForm.BaseForm
    {
        TextBox box;
        string WorkCode = string.Empty;
        public WorkRecordPopUp(string WorkCode)
        {
            InitializeComponent();
            this.WorkCode = WorkCode;
        }

        private void NUMbutton_Click(object sender, EventArgs e)
        {
            if (box == null)
                return;
            string text = box.Text;
            int Num = Convert.ToInt32(text);
            if (Num > 100000)
                return;
            int add = Convert.ToInt32(((Control)sender).Text);
            Num = Num * 10 + add;
           
            box.Text = Num.ToString();
        }

        private void tbx_MouseClick(object sender, MouseEventArgs e)
        {
            box = (TextBox)sender;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (box == null)
                return;
            string text = box.Text;
            int Num = Convert.ToInt32(text);
            if (Num < 10)
                Num = 0;
            else
                Num = Num / 10;

            box.Text = Num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(tbx_GoodsQuantity.Text);
            if((this.Owner) != null)
            {
                ((MDIForm)this.Owner).Count = count;
            }
            HttpClient client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/WorkRecord/WorkQuantity/" + WorkCode+"/" + tbx_BadQuantity.Text + "/" + tbx_GoodsQuantity.Text + "/" + Global.Global.employees.Emp_Code;

            HttpResponseMessage rm = await client.GetAsync(UrlApi);

            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<bool> apiMessage = jss.Deserialize<ApiMessage<bool>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("입력 실패.");
                }
            }
        }
    }
}
