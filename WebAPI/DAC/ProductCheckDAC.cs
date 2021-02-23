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
    public class ProductCheckDAC
    {
        ILog log = null;

        public ProductCheckDAC()
        {

        }

        public List<ProductCheckVO> ProductCheckFromProduct(string Prod_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"select Prod_Code, Check_Type, Check_System, Check_Point, Check_Item, Check_Standard from ProductCheck where Prod_Code  = @Prod_Code";
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@Prod_Code", Prod_Code);
                    List<ProductCheckVO> list = Helper.DataReaderMapToList<ProductCheckVO>(cmd.ExecuteReader());
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