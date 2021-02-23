using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using VO;
using WebAPI.Global;

namespace WebAPI.DAC
{
    public class ViewDAC
    {
        ILog log = null;

        public ViewDAC() { }

        public List<TeamInfoVO> GetTeamFormEmp(string EmpCode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = "select Team_Code, Team_Name, Team_Chief, Team_Part from View_EmpForTeam where Emp_Code = @Emp_Code";
                    cmd.Parameters.AddWithValue("@Emp_Code", EmpCode);
                    cmd.Connection.Open();
                    List<TeamInfoVO> list = Helper.DataReaderMapToList<TeamInfoVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public List<View_WareHouseDetailVO> GetView_WareHouseDetail(string WH_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"select WH_Code
                    ,Prod_Code
                    ,Prod_Name
                    ,WH_PsyCount
                    ,WH_LogCount from View_WareHouseDetail where WH_Code = @WH_Code";
                    cmd.Parameters.AddWithValue("@WH_Code", WH_Code);
                    cmd.Connection.Open();
                    List<View_WareHouseDetailVO> list = Helper.DataReaderMapToList<View_WareHouseDetailVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public List<View_ContractVO> GetView_Orders_CodeVO()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"select Contract_Code, Comp_Code, Comp_Code_Name, Contract_Destination, Contract_DueDate
                                    , Contract_Confirm, Contract_Finish, Contract_Note from View_Contract 
                                    where Contract_Confirm = 'Y' and Contract_Finish = 'N'";
                    cmd.Connection.Open();
                    List<View_ContractVO> list = Helper.DataReaderMapToList<View_ContractVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public bool SP_InsetProductWH(int Count)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"SP_InsetProductWH";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Count", Count);
                    cmd.Connection.Open();
                    bool result = cmd.ExecuteNonQuery() > 0 ? true : false;
                    cmd.Connection.Close();

                    return result;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public List<View_ContractVO> GetCodeView_Orders_CodeVO(string code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = @"select Contract_Code, Comp_Code, Comp_Code_Name, Contract_Destination, Contract_DueDate, Contract_Confirm
                                    , Contract_Finish, Contract_Note from View_Contract where Contract_Code = @Contract_Code";

                    cmd.CommandText = sql;
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.Parameters.AddWithValue("@Contract_Code", code);


                    cmd.Connection.Open();
                    List<View_ContractVO> list = Helper.DataReaderMapToList<View_ContractVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();


                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public List<View_ContractDetailVO> GetView_OrdersDetail_CodeVO(string ordercode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = @"select Contract_Code, Prod_Code, Prod_Name, Contract_Count, Contract_ShippingCount, Contract_CancelCount from View_ContractDetail
    where Contract_Code = @Orders_Code";
                    cmd.Parameters.AddWithValue("@Orders_Code", ordercode);
                    cmd.Connection.Open();
                    List<View_ContractDetailVO> list = Helper.DataReaderMapToList<View_ContractDetailVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public bool SP_OutToProduct(decimal Count, string ProductCode, string WH_Code, string uid, string Contract_Code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = @"SP_OutToProduct";

                    cmd.CommandText = sql;
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Count", Count);
                    cmd.Parameters.AddWithValue("@ProductCode", ProductCode);
                    cmd.Parameters.AddWithValue("@WH_Code", WH_Code);
                    cmd.Parameters.AddWithValue("@uid", uid);
                    cmd.Parameters.AddWithValue("@Contract_Code", Contract_Code);

                    cmd.Connection.Open();
                    bool result = cmd.ExecuteNonQuery() > 0 ? true: false;
                    cmd.Connection.Close();


                    return result;
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