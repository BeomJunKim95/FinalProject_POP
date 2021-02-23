using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using VO;
using WebAPI.Global;

namespace WebAPI.DAC
{
    public class ProcessDetailDAC
    {
        ILog log = null;

        public ProcessDetailDAC()
        {

        }

        public List<View_ProcessForProductVO> ProcessForProduct(string Prod_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"select Pcs_Name,PcsD_Code, PcsD_Name from View_ProcessForProduct 
                                        where BOR_State = 'Y' and PscD_State = 'Y' and PscD_State = 'Y' and Prod_Code = @Prod_Code";
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@Prod_Code", Prod_Code);
                    List<View_ProcessForProductVO> list = Helper.DataReaderMapToList<View_ProcessForProductVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                //log.Error("GetUserInfo() 오류: " + err.Message);
                return null;
            }
        }
    }
}