using VO;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using WebAPI.Global;
using System.Diagnostics;

namespace WebAPI.DAC
{
    public class EmployeesDAC
    {
        ILog log = null;

        public EmployeesDAC()
        {

        }


        public EmployeesVO EmpLogin(string EmpCode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"select Emp_Code, Emp_Name, Emp_HireDate, Emp_RetireDate, Emp_Phone, Emp_Email, Emp_PostCode, Emp_Addr, Emp_AddrDetail, Emp_Pwd,  Emp_Addbutton, Emp_Updatebutton, Emp_Deletebutton
                                        from Employees
                                        where Emp_Code = @Emp_Code";
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@Emp_Code", EmpCode);
                    List<EmployeesVO> list = Helper.DataReaderMapToList<EmployeesVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return (list != null && list.Count > 0) ? list[0] : null;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }
    }
}
