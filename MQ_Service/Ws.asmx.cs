using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace MQ_Service
{
    /// <summary>
    /// Summary description for Ws
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Ws : System.Web.Services.WebService
    {


        public string connMain = System.Configuration.ConfigurationManager.ConnectionStrings["StringMain"].ConnectionString;
        public string connInter = System.Configuration.ConfigurationManager.ConnectionStrings["StringInter"].ConnectionString;
        [WebMethod]
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
        [WebMethod]
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
     
        [WebMethod]
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
