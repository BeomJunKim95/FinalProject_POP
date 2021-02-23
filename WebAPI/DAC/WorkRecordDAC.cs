using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebAPI.Global;

namespace WebAPI.DAC
{
    public class WorkRecordDAC
    {

        public WorkRecordDAC()
        {

        }

        public bool SP_StartWorkRecord(string WorkPlanCode,string Fst_Writer)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"SP_StartWorkRecord";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@WorkPlan_Code", WorkPlanCode);
                    cmd.Parameters.AddWithValue("@Fst_Writer", Fst_Writer);
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool WorkQuantityInput(string WorkPlanCode,int BadQuantity,int GoodsQuantity, string Lst_Writer)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"Update WorkRecord set Work_BadQuantity = @Work_BadQuantity,
					Work_GoodsQuantity = @Work_GoodsQuantity,
					Lst_Writer = @Lst_Writer,
					Lst_WriteDate = getdate()
					where WorkPlan_Code = @WorkPlan_Code";
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@WorkPlan_Code", WorkPlanCode);
                    cmd.Parameters.AddWithValue("@Work_BadQuantity", BadQuantity);
                    cmd.Parameters.AddWithValue("@Work_GoodsQuantity", GoodsQuantity);
                    cmd.Parameters.AddWithValue("@Lst_Writer", Lst_Writer);
                    bool returl = cmd.ExecuteNonQuery() > 0;
                    cmd.Connection.Close();
                    return returl;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

    }
}