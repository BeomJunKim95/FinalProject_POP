using POPDisplay.MainForm;
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

namespace POPDisplay.MDI
{
    public partial class MDIForm : Form
    {
        WorkOrderInfo workOrder;
        ProcessDetailInfo processDetail;
        public SP_WorkOrderSherchTeamVO selectdWork;
        ProductCheckInfo product;
        public int Count;
        public MDIForm()
        {
            InitializeComponent();
        }


        #region 자식폼 닫음
        private void ChildClose()
        {
            if (this.ActiveMdiChild != null && this.ActiveMdiChild is FacilityInfo)
            {
                this.ActiveMdiChild.Hide();
            }else if(this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }
        #endregion

        #region 데이터 다시 바인딩
        private void DataSourceRebainding()
        {
            object data = workOrder.dgv_WorkOrder.DataSource;
            workOrder.dgv_WorkOrder.DataSource = null;
            workOrder.dgv_WorkOrder.DataSource = data;
        }
        #endregion

        #region 선택작업
        private bool SetSelectOrder()
        {
            if (workOrder == null || workOrder.dgv_WorkOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("먼저 작업을 선택하여 주세요");
                return false;
            }

            selectdWork = ((SP_WorkOrderSherchTeamVO)workOrder.dgv_WorkOrder.SelectedRows[0].DataBoundItem);
            return true;
        }
        #endregion

        #region 이벤트
        #region 닫기버튼
        private void pcb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 닫는중 로그인 폼 띄워줌
        private void MDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
        #endregion

        #region 최소화
        private void pcb_Minmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region 작업지시 조회
        private void btn_WrokOrderForm_Click(object sender, EventArgs e)
        {
            ChildClose();
            workOrder = new WorkOrderInfo();
            workOrder.Text = "작업지시 조회";
            this.OpenCreateForm(workOrder, true);
            workOrder.Dock = DockStyle.Fill;
        }
        #endregion

        #region 작업 시작버튼
        private async void btn_StartWork_Click(object sender, EventArgs e)
        {
            if(!SetSelectOrder())
                return;
            #region 작업 조회및 작업 시작
            HttpClient client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/WorkOrder/Start/" + selectdWork.WO_Code + "/" + Global.Global.employees.Emp_Code;
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<bool> apiMessage = jss.Deserialize<ApiMessage<bool>>(result);
                if (apiMessage.ResultCode == "S")
                {
                    selectdWork.WO_State = "Wost003";
                    selectdWork.WO_CodeName = "작업 시작";
                    DataSourceRebainding();
                }
                else
                {
                    MessageBox.Show("검색된 작업 지시 사항이 없습니다.");
                }
            }
            #endregion



        }
        #endregion

        #region 작업 종료
        private async void btn_Stop_Click(object sender, EventArgs e)
        {
            if (!SetSelectOrder())
                return;
            HttpClient client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/WorkOrder/Stop/" + selectdWork.WO_Code;
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<bool> apiMessage = jss.Deserialize<ApiMessage<bool>>(result);
                if (apiMessage.ResultCode == "S")
                {
                    selectdWork.WO_State = "Wost004";
                    selectdWork.WO_CodeName = "작업 중지";
                    DataSourceRebainding();
                }
                else
                {
                    MessageBox.Show("검색된 작업 지시 사항이 없습니다.");
                }
            }
        }
        #endregion

        private void btn_ProductCheck_Click(object sender, EventArgs e)
        {
            if (selectdWork == null)
            {
                MessageBox.Show("선택된 작업이 없습니다.");
                return;
            }
            ChildClose();
            product = new ProductCheckInfo(selectdWork.Prod_Code);
            product.Text = "작업 물품 체크 리스트 / 작업 물품 : " + selectdWork.Prod_Name;
            this.OpenCreateForm(product, true);
            product.Dock = DockStyle.Fill;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (selectdWork == null)
            {
                MessageBox.Show("선택된 작업이 없습니다.");
                return;
            }
            ChildClose();
            processDetail = new ProcessDetailInfo(selectdWork.Prod_Code);
            processDetail.Text = "작업 프로세스 조회 / 작업 물품 : " + selectdWork.Prod_Name;
            this.OpenCreateForm(processDetail, true);
            processDetail.Dock = DockStyle.Fill;

        }

        private async void btn__Click(object sender, EventArgs e)
        {
            if (selectdWork == null)
                return;
            HttpClient client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/Facility/" + selectdWork.Fac_Code;
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<FacilityVO> apiMessage = jss.Deserialize<ApiMessage<FacilityVO>>(result);
                if (apiMessage.ResultCode == "S")
                {
                    FacilityInfo facility = new FacilityInfo(apiMessage.Data, selectdWork.WO_EstimatedQuantity);
                    this.OpenCreateForm(facility, true);
                    facility.Dock = DockStyle.Fill;
                }
                else
                {
                    MessageBox.Show("조회된 설비가 없습니다.");
                }
            }
            else
                MessageBox.Show("조회된 설비가 없습니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(selectdWork == null)
            {
                MessageBox.Show("작업을 선택해 주세요.");
                return;
            }
            WorkRecordPopUp workRecordPopUp = new WorkRecordPopUp(selectdWork.WO_Code);
            workRecordPopUp.Owner = this;
            this.OpenCreateForm(workRecordPopUp);
        }



        #endregion

        private async void button2_Click(object sender, EventArgs e)
        {
            if (selectdWork == null)
                return;
            if(MessageBox.Show("선택한 작업을 끝내시겠습니까?", "작업종료", buttons: MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            HttpClient client = new HttpClient();
            string UrlApi;
            HttpResponseMessage rm;
            if (selectdWork.Fac_Code == "Fac0602")
            {
                UrlApi = Global.Global.APIAddress + "/ProductCheck/Count/" + Count;
                rm = await client.GetAsync(UrlApi);
                if (rm.IsSuccessStatusCode)
                {
                    string result = await rm.Content.ReadAsStringAsync();
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    ApiMessage<bool> apiMessage = jss.Deserialize<ApiMessage<bool>>(result);
                    if (apiMessage.ResultCode == "S")
                    {

                    }
                }
            }
            UrlApi = Global.Global.APIAddress + "/WorkOrder/End/" + selectdWork.WO_Code;
            rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<bool> apiMessage = jss.Deserialize<ApiMessage<bool>>(result);
                if (apiMessage.ResultCode == "S")
                {
                    ((List<SP_WorkOrderSherchTeamVO>)workOrder.dgv_WorkOrder.DataSource).Remove(selectdWork);
                    selectdWork = null;
                    lbl_WorkOrder.Text = null;
                    DataSourceRebainding();
                }
                else
                {
                    MessageBox.Show("검색된 작업 지시 사항이 없습니다.");
                }
            }

            
        }
    }
}
