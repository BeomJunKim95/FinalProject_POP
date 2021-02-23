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
    public class FacilityDAC
    {
        public FacilityVO SelectFacility(string Fac_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"SELECT [FacGrp_Code],[Fac_Code],[Fac_Name],[Fac_Enable],[Fac_Outsourcing]
                    ,[Fac_ImgPath],[Fac_MaterialWareHouse],[Fac_GoodsWareHouse],[Fac_FaultyWareHouse]
                    FROM [TEAM4].[dbo].[Facility] where Fac_Code = @Fac_Code";
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@Fac_Code", Fac_Code);
                    List<FacilityVO> list = Helper.DataReaderMapToList<FacilityVO>(cmd.ExecuteReader());
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