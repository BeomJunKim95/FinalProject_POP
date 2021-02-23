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
	public partial class ProductCheckInfo : POPDisplay.BaseForm.BaseForm
	{
		string prod_Code = string.Empty;
        HttpClient Client = new HttpClient();
        public ProductCheckInfo(string prod_Code)
		{
			InitializeComponent();
			this.prod_Code = prod_Code;
		}

        private async void ProductCheckInfo_Load(object sender, EventArgs e)
        {
            DGV_Set();

            string UrlApi = Global.Global.APIAddress + "/ProductCheck/Prod/" + prod_Code;
            HttpResponseMessage rm = await Client.GetAsync(UrlApi);


            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<List<ProductCheckVO>> apiMessage = jss.Deserialize<ApiMessage<List<ProductCheckVO>>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    dgv_pck.DataSource = apiMessage.Data;
                }
                else
                {
                    MessageBox.Show("검색된 작업 지시 사항이 없습니다.");
                }
            }


        }

        private void DGV_Set()
        {
            dgv_pck.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_pck, "검사 타입", "Check_Type");
            CommonUtil.AddGridTextColumn(dgv_pck, "검사 방식", "Check_System");
            CommonUtil.AddGridTextColumn(dgv_pck, "검사 항목", "Check_Point");
            CommonUtil.AddGridTextColumn(dgv_pck, "계측 장비", "Check_Item");
            CommonUtil.AddGridTextColumn(dgv_pck, "검사 기준", "Check_Standard");
        }
    }
}
