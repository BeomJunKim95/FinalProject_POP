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

namespace POPWareHouse.MainForm
{
    public partial class OrdersForm: POPWareHouse.BaseForm.BaseForm
    {
        List<View_ContractVO> orders;
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            SetDgv();
            GetData();
        }

        private void SetDgv()
        {
            dgv_Order.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_Order, "발주 코드", "Contract_Code", 150);
            CommonUtil.AddGridTextColumn(dgv_Order, "회사명", "Comp_Code_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_Order, "배송지", "Contract_Destination", 200);
            CommonUtil.AddGridTextColumn(dgv_Order, "발주일", "Contract_DueDate", 150);


            dgv_OrderDetail.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_OrderDetail, "물품명", "Prod_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_OrderDetail, "발주 수량", "Contract_Count", 150);
            CommonUtil.AddGridTextColumn(dgv_OrderDetail, "출고 수량", "Contract_ShippingCount", 150);
            CommonUtil.AddGridTextColumn(dgv_OrderDetail, "취소 수량", "Contract_CancelCount", 150);
        }
        private async void GetData()
        {
            HttpClient client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/Orders/GetOrders";
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<List<View_ContractVO>> apiMessage = jss.Deserialize<ApiMessage<List<View_ContractVO>>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    orders = apiMessage.Data;
                }
            }

            dgv_Order.DataSource = orders;

        }

        private async void dgv_Order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            View_ContractVO item = (View_ContractVO)dgv_Order.Rows[e.RowIndex].DataBoundItem;
            HttpClient client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/Orders/GetOrderDetail/" + item.Contract_Code;
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<List<View_ContractDetailVO>> apiMessage = jss.Deserialize<ApiMessage<List<View_ContractDetailVO>>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    dgv_OrderDetail.DataSource = apiMessage.Data;

                    this.MdiParent.Controls["panel1"].Controls["lbl_SelectOrke"].Text = item.Contract_Code.ToString();
                    ((MDI.MDIForm)this.MdiParent).selectVo = item;
                }
            }
        }
    }
}
