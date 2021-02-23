using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace VO
{
    public class SP_WorkOrderSherchTeamVO
    {
        public string WO_Code { get; set; }
        public string WO_CodeName { get; set; }
        public string Prod_Name { get; set; }
        public string Team_Name { get; set; }
        public string WO_WorkTimeName { get; set; }
        public int WO_EstimatedQuantity { get; set; }
        public int WO_OrderQuantity { get; set; }
        public int WO_TactTime { get; set; }
        public DateTime WO_EstimatedEnd { get; set; }
        public int WO_Priority { get; set; }
        public string WO_WorkTime { get; set; }
        public string WO_State { get; set; }
        public string Prod_Code { get; set; }
        public string Fac_Code { get; set; }
        public string Team_Code { get; set; }
    }

    public class View_ProcessForProductVO
    {
        public string Pcs_Name { get; set; }
        public string PcsD_Code { get; set; }
        public string PcsD_Name { get; set; }
    }

    public class Imagedata
    {
        public byte[] image;
        public string filename;
    }

    public class View_WareHouseDetailVO
    {
        public string WH_Code { get; set; }
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public decimal WH_PsyCount { get; set; }
        public decimal WH_LogCount { get; set; }
    }


    public class View_ContractVO
    {
        public string Contract_Code { get; set; }
        public string Comp_Code { get; set; }
        public string Contract_Destination { get; set; }
        public DateTime Contract_DueDate { get; set; }
        public string Contract_Confirm { get; set; }
        public string Contract_Finish { get; set; }
        public string Contract_Note { get; set; }
        public string Comp_Code_Name { get; set; }
    }

    public class View_ContractDetailVO
    {
        public string Contract_Code { get; set; }
        public string Prod_Code { get; set; }
        public string Prod_Name { get; set; }
        public int Contract_Count { get; set; }
        public int Contract_ShippingCount { get; set; }
        public int Contract_CancelCount { get; set; }
    }

}
