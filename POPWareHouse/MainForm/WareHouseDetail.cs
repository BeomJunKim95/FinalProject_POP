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
    public partial class WareHouseDetail : POPWareHouse.BaseForm.BaseForm
    {
        List<View_WareHouseDetailVO> data = null;
        public WareHouseDetail(List <View_WareHouseDetailVO> data )
        {
            InitializeComponent();
            this.data = data;
        }

        private void WareHouseDetail_Load(object sender, EventArgs e)
        {
            dgv_WareHouseDetail.SetGridColumn();
            CommonUtil.AddGridTextColumn(dgv_WareHouseDetail, "물품 코드", "Prod_Code", 150);
            CommonUtil.AddGridTextColumn(dgv_WareHouseDetail, "물품명", "Prod_Name", 150);
            CommonUtil.AddGridTextColumn(dgv_WareHouseDetail, "물리 재고량", "WH_PsyCount", 150);
            CommonUtil.AddGridTextColumn(dgv_WareHouseDetail, "논리 재고량", "WH_LogCount", 150);


            dgv_WareHouseDetail.DataSource = data;
        }

        private void dgv_WareHouseDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
