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
    public partial class WorkOrderInfo : POPDisplay.BaseForm.BaseForm
    {
        HttpClient client;
        public WorkOrderInfo()
        {
            InitializeComponent();
        }

        private async void WorkOrderInfo_Load(object sender, EventArgs e)
        {
            DgvSet();

            client = new HttpClient();
            string code = string.Empty;
            Global.Global.TeamInfos.ForEach(x =>
            {
                code += x.Team_Code + "|";
            });
            code = code.Left(code.Length - 1);

            string UrlApi = Global.Global.APIAddress + "/WorkOrder/Teams/" + code;
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<List<SP_WorkOrderSherchTeamVO>> apiMessage = jss.Deserialize<ApiMessage<List<SP_WorkOrderSherchTeamVO>>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    dgv_WorkOrder.DataSource = apiMessage.Data;
                }
                else
                {
                    MessageBox.Show("검색된 작업 지시 사항이 없습니다.");
                }
            }
        }

        private void DgvSet()
        {
            dgv_WorkOrder.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "작업코드", "WO_Code");
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "작업상태", "WO_CodeName");
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "물품", "Prod_Name", 200);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "작업팀", "Team_Name");
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "작업시간", "WO_WorkTimeName");
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "지시수량", "WO_EstimatedQuantity");
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "목표수량", "WO_OrderQuantity");
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "목표시간", "WO_EstimatedEnd", 200 , Format: "yyyy-MM-dd");
        }

        private void dgv_WorkOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            this.MdiParent.Controls["panel1"].Controls["lbl_WorkOrder"].Text = dgv_WorkOrder["WO_Code", e.RowIndex].Value.ToString();
            ((MDIForm)this.MdiParent).selectdWork = (SP_WorkOrderSherchTeamVO)dgv_WorkOrder.Rows[e.RowIndex].DataBoundItem;
        }
    }
}
