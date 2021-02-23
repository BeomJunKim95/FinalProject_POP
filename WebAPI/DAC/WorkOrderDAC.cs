using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using VO;
using WebAPI.Global;

namespace WebAPI.DAC
{
    public class WorkOrderDAC
    {
        ILog log = null;

        public WorkOrderDAC() { }

        public List<SP_WorkOrderSherchTeamVO> SP_WorkOrderSherchTeam(string Teams)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = "SP_WorkOrderSherchTeam";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StringTeamCode", Teams);
                    cmd.Connection.Open();
                    List<SP_WorkOrderSherchTeamVO> list = Helper.DataReaderMapToList<SP_WorkOrderSherchTeamVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                log.Error("GetAllUsers() 오류: " + err.Message);
                return null;
            }
        }


        public bool StartWorkFromCode(string WO_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"Update WorkOrder set WO_State = 'Wost003'
                                        where WO_Code = @WO_Code";
                    cmd.Parameters.AddWithValue("@WO_Code", WO_Code);
                    cmd.Connection.Open();
                    bool result = cmd.ExecuteNonQuery() > 0;
                    cmd.Connection.Close();

                    return result;
                }
            }
            catch (Exception err)
            {
                log.Error("GetAllUsers() 오류: " + err.Message);
                return false;
            }
        }

        public bool StopWorkFromCode(string WO_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"Update WorkOrder set WO_State = 'Wost004'
                                        where WO_Code = @WO_Code and WO_State = 'Wost003'";
                    cmd.Parameters.AddWithValue("@WO_Code", WO_Code);
                    cmd.Connection.Open();
                    bool result = cmd.ExecuteNonQuery() > 0;
                    cmd.Connection.Close();

                    return result;
                }
            }
            catch (Exception err)
            {
                log.Error("GetAllUsers() 오류: " + err.Message);
                return false;
            }
        }

        public bool EndWorkFromCode(string WO_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"Update WorkOrder set WO_State = 'Wost006'
                                        where WO_Code = @WO_Code
                                        Update WorkRecord set Work_EndDate = getdate()
                                        where WorkPlan_Code = @WorkPlan_Code";
                    cmd.Parameters.AddWithValue("@WO_Code", WO_Code);
                    cmd.Parameters.AddWithValue("@WorkPlan_Code", WO_Code);
                    cmd.Connection.Open();
                    bool result = cmd.ExecuteNonQuery() > 0;
                    cmd.Connection.Close();

                    return result;
                }
            }
            catch (Exception err)
            {
                log.Error("GetAllUsers() 오류: " + err.Message);
                return false;
            }
        }
    }
}