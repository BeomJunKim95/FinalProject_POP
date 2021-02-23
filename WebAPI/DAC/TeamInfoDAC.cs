using VO;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using WebAPI.Global;

namespace WebAPI.DAC
{
    public class TeamInfoDAC
    {
        ILog log = null;

        public TeamInfoDAC() { }

        public List<TeamInfoVO> GetAllEmployeess()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = "select Team_Code, Team_Name, Team_Chief, Team_Part from View_EmpForTeam";

                    cmd.Connection.Open();
                    List<TeamInfoVO> list = Helper.DataReaderMapToList<TeamInfoVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch(Exception err)
            {
                log.Error("GetAllUsers() 오류: " + err.Message);
                return null;
            }
        }

        public List<TeamInfoVO> GetTeamInfoForEmp(string EmpCode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = "select Team_Code, Team_Name, Team_Chief, Team_Part from View_EmpForTeam where Emp_Code = @Emp_Code";

                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@Emp_Code", EmpCode);
                    List<TeamInfoVO> list = Helper.DataReaderMapToList<TeamInfoVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return (list != null && list.Count > 0) ? list : null;
                }
            }
            catch (Exception err)
            {
                log.Error("GetUserInfo() 오류: " + err.Message);
                return null;
            }
        }

        //public string SaveEmployees(UserVO user)
        //{
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = new SqlConnection(strConn);
        //            cmd.CommandText = "SaveUser";
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            cmd.Parameters.AddWithValue("@Id", user.Id);
        //            cmd.Parameters.AddWithValue("@Name", user.Name);
        //            cmd.Parameters.AddWithValue("@Email", user.Email);
        //            cmd.Parameters.AddWithValue("@Mobile", user.Mobile);
        //            cmd.Parameters.AddWithValue("@Address", user.Address);
        //            cmd.Parameters.AddWithValue("@IsActive", user.IsActive);

        //            cmd.Parameters.Add(new SqlParameter("@ReturnCode", SqlDbType.NVarChar, 5));
        //            cmd.Parameters["@ReturnCode"].Direction = ParameterDirection.Output;

        //            cmd.Connection.Open();
        //            cmd.ExecuteNonQuery();
        //            cmd.Connection.Close();

        //            return cmd.Parameters["@ReturnCode"].Value.ToString();
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        log.Error("SaveUser() 오류: " + err.Message);
        //        return null;
        //    }
        //}

        //public string DeleteEmployees(int id)
        //{
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = new SqlConnection(strConn);
        //            cmd.CommandText = "delete from Users where Id=@id";

        //            cmd.Parameters.AddWithValue("@id", id);

        //            cmd.Connection.Open();
        //            int iRowAffect = cmd.ExecuteNonQuery();
        //            cmd.Connection.Close();

        //            return (iRowAffect > 0) ? "C200" : "C203";
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        log.Error("DeleteUser() 오류: " + err.Message);
        //        return null;
        //    }
        //}
    }
}