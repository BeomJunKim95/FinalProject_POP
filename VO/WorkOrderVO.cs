using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WorkOrderVO
    {
        public string WO_Code { get; set; }
        public string Prod_Code { get; set; }
        public string WO_State { get; set; }
        public string Fac_Code { get; set; }
        public string Team_Code { get; set; }
        public string WO_WorkTime { get; set; }
        public string WO_EstimatedQuantity { get; set; }
        public string WO_OrderQuantity { get; set; }
        public string WO_TactTime { get; set; }
        public string WO_EstimatedEnd { get; set; }
        public string WO_Priority { get; set; }
    }
}
