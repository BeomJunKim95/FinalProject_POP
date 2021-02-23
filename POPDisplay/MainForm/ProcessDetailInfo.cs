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
	public partial class ProcessDetailInfo : POPDisplay.BaseForm.BaseForm
	{
		string ProductCode = string.Empty;
        HttpClient Client = new HttpClient();
		public ProcessDetailInfo(string ProductCode)
		{
			InitializeComponent();
			this.ProductCode = ProductCode;
		}

        private async void ProcessDetailInfo_Load(object sender, EventArgs e)
        {
            Dgv_Set();

            string UrlApi = Global.Global.APIAddress + "/ProcessDetail/Prod/" + ProductCode;
            HttpResponseMessage rm = await Client.GetAsync(UrlApi);

            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<List<View_ProcessForProductVO>> apiMessage = jss.Deserialize<ApiMessage<List<View_ProcessForProductVO>>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    dgv_pcs.DataSource = apiMessage.Data;
                }
                else
                {
                    MessageBox.Show("검색된 작업 지시 사항이 없습니다.");
                }
            }
        }

        private void Dgv_Set()
        {
            dgv_pcs.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_pcs, "공정분류", "Pcs_Name", 200);
            CommonUtil.AddGridTextColumn(dgv_pcs, "세부 공정 코드", "PcsD_Code", 200);
            CommonUtil.AddGridTextColumn(dgv_pcs, "세부 공정 명", "PcsD_Name", 250);
        }
    }
}
