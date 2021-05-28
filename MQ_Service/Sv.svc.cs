using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ServiceModel.Activation;

namespace MQ_Service
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Sv
    {
        public string connMain = System.Configuration.ConfigurationManager.ConnectionStrings["StringMain"].ConnectionString;
        public string connInter = System.Configuration.ConfigurationManager.ConnectionStrings["StringInter"].ConnectionString;
        [OperationContract]
        public DataTable QueryDataMain(string strSQL, string redial)
        {
            DataSet ds = new DataSet();
            if (redial == "")
            {
                using (SqlConnection conn = new SqlConnection(connMain))
                {
                    using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                        }
                    }
                }
                return ds.Tables[0];
            }
            else return null;
        }
        [OperationContract]
        public DataTable QueryDataInter(string strSQL, string redial)
        {
            DataSet ds = new DataSet();
            if (redial == "")
            {
                using (SqlConnection conn = new SqlConnection(connInter))
                {
                    using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                        }
                    }
                }
                return ds.Tables[0];
            }
            else return null;
        }
        [OperationContract]
        public Boolean ExecuteInter(string strSQL, string redial)
        {
            try
            {
                if (redial == "")
                    using (SqlConnection conn = new SqlConnection(connMain))
                    {
                        using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                        {
                            cmd.Connection.Open();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            return true;
                        }
                    }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        [OperationContract]
        public Boolean ExecuteMain(string strSQL, string redial)
        {
            try
            {
                if (redial == "")
                    using (SqlConnection conn = new SqlConnection(connMain))
                    {
                        using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                        {
                            cmd.Connection.Open();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            return true;
                        }
                    }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
