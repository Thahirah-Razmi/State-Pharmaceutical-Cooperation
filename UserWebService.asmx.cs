using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;

namespace State_Pharmaceutical_Cooperation
{
    /// <summary>
    /// Summary description for UserWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWebService : System.Web.Services.WebService
    {
        SqlConnection sqlCon = null;
        public SqlConnection getConnection()
        {
            try
            {
                sqlCon = new SqlConnection("data source=DESKTOP-4V563VC\\SQLEXPRESS;initial catalog=State_Pharmaceutical_Cooperation;Integrated Security=True;");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to Db" + ex);
            }
            return sqlCon;
        }

        [WebMethod]
        public string AutoSupplierID()
        {
            string SupplierID = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select SupplierID from SupplierTable", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                bool records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    string idString = id.Substring(2);
                    int CTR = Int32.Parse(idString);
                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;
                        SupplierID = "SP00" + CTR;
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        SupplierID = "SP0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        SupplierID = "SP" + CTR;
                    }
                }
                else
                {
                    SupplierID = "SP001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                SupplierID = e1.ToString();
            }
            return SupplierID;
        }

        [WebMethod]
        public string AutoUserID()
        {
            string UserID = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select UserID from UserTable", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                bool records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    string idString = id.Substring(2);
                    int CTR = Int32.Parse(idString);
                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;
                        UserID = "US00" + CTR;
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        UserID = "US0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        UserID = "US" + CTR;
                    }
                }
                else
                {
                    UserID = "US001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                UserID = e1.ToString();
            }
            return UserID;
        }

        [WebMethod]
        public string RegisterSupplier(string SupplierID, string SupplierName, string Username, string Password, string ContactNumber)
        {
            int noRecords = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into SupplierTable values('" + SupplierID + "', '" + SupplierName + "', '" + Username + "', '" + Password + "', '" + ContactNumber + "');", sqlCon);
                noRecords += cmd.ExecuteNonQuery();

                SqlCommand cmdUser = new SqlCommand("insert into UserTable values('" + AutoUserID() + "', '" + Username + "', '" + Password + "', 'Supplier');", sqlCon);
                noRecords += cmdUser.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return noRecords.ToString();
        }

        [WebMethod]
        public string AuthenticateUser(string Username, string Password)
        {
            string result = "Login Unsuccessful";
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Usertype FROM UserTable WHERE Username= '" + Username+ "' AND Password= '" + Password + "'", sqlCon);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    result = dr["Usertype"].ToString();
                }
                else
                {
                    result = "Invalid Username or Password";
                }
            }
            catch(Exception ex)
            {
                result = "Error finding user" + ex;
            }
            return result;
        }
    }
}
