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
    public class WareHouseDAC
    {
        public ViewWareHouseVO SelectWareHouse(string WH_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"select WH_Code, WH_Name, WH_Type, WH_State, WH_Type_Name from View_WareHouse WHERE WH_Code = @WH_Code AND WH_State = 'Y' ";
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@WH_Code", WH_Code);
                    List<ViewWareHouseVO> list = Helper.DataReaderMapToList<ViewWareHouseVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list[0];
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