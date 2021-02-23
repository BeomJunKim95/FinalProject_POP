using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    public class EmployeeDAC : IDisposable
    {
        string strConn;
        ILog log = null;
        SqlConnection conn;

        public EmployeeDAC(ILog log)
        {
            this.log = log;
            if(GlobalInfo.strConn.Length < 1)
            {
                EncrytLibrary.AES ase = new EncrytLibrary.AES();
                GlobalInfo.strConn = ase.AESDecrypt256(GlobalInfo.aesConn);
            }
            this.strConn = GlobalInfo.strConn;
            conn = new SqlConnection(this.strConn);
            conn.Open();
        }

        public bool LoginCheck(string text)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select count(*) from Employees where Emp_Code = @id";
                    cmd.Parameters.AddWithValue("@id", text);

                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());

                    if (cnt > 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (Exception err)
            {
                log.Debug("LoginCheck Error : " + err.Message);
                return false;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }



    }
}
