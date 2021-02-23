using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WareHouseVO
    {
        public string WH_Code { get; set; }
        public string WH_Name { get; set; }
        public string WH_Type { get; set; }
        public string WH_State { get; set; }
    }

    public class ViewWareHouseVO
    {
        public string WH_Code { get; set; }
        public string WH_Name { get; set; }
        public string WH_Type { get; set; }
        public string WH_State { get; set; }
        public string WH_Type_Name { get; set; }
    }

}
