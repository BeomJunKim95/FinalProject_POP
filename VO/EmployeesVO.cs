using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class EmployeesVO
    {
        public string Emp_Code { get; set; }
        public string Emp_Name { get; set; }
        public DateTime Emp_HireDate { get; set; }
        public DateTime Emp_RetireDate { get; set; }
        public string Emp_Phone { get; set; }
        public string Emp_Email { get; set; }
        public int Emp_PostCode { get; set; }
        public string Emp_Addr { get; set; }
        public string Emp_AddrDetail { get; set; }
        public string Emp_Pwd { get; set; }
        public bool Emp_Addbutton   { get; set; }
        public bool Emp_Updatebutton { get; set; }
        public bool Emp_Deletebutton { get; set; }
    }

    public class EmployeesTeamVO
    {
        public string Emp_Code              { get; set; }
        public string Emp_Name              { get; set; }
        public DateTime Emp_HireDate        { get; set; }
        public DateTime Emp_RetireDate      { get; set; }
        public string Emp_Phone             { get; set; }
        public string Emp_Email             { get; set; }
        public int Emp_PostCode             { get; set; }
        public string Emp_Addr              { get; set; }
        public string Emp_AddrDetail        { get; set; }
        public string Emp_Pwd               { get; set; }
        public string Team_Code             { get; set; }
        public bool Emp_Addbutton           { get; set; }
        public bool Emp_Updatebutton        { get; set; }
        public bool Emp_Deletebutton        { get; set; }
    }
}
