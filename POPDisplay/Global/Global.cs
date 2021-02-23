using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace POPDisplay.Global
{
    public static class Global
    {
        public static string APIAddress = ConfigurationManager.AppSettings["APIAddress"];
        public static EmployeesVO employees; 
        public static List<TeamInfoVO> TeamInfos;
    }
}
