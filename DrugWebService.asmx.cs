using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace State_Pharmaceutical_Cooperation
{
    /// <summary>
    /// Summary description for DrugWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DrugWebService : System.Web.Services.WebService
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
        public string AutoDrugID()
        {
            string DrugID = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select DrugID from DrugTable", sqlCon);
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
                        DrugID = "DR00" + CTR;
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        DrugID = "DR0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        DrugID = "DR" + CTR;
                    }
                }
                else
                {
                    DrugID = "DR001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                DrugID = e1.ToString();
            }
            return DrugID;
        }

        [WebMethod]
        public DataSet getDrugName()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select DrugName from DrugTable", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "DrugTable");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Drug Name " + ex);
            }
            return ds;
        }

        [WebMethod]
        public string getDrugId(string DrugName)
        {
            string DrugID = "";
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select DrugID from DrugTable where DrugName = '" + DrugName + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                Boolean records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        DrugID = dr[0].ToString();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Drug Name" + ex);
            }
            return DrugID;
        }

        [WebMethod]
        public String insertDrug(string DrugID, string DrugName, string SupplierID, string Description, string Price, string Stock)
        {
            int NoRows = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into DrugTable values('" + DrugID + "', '" + DrugName + "', '" + SupplierID + "', '" + Description + "', " + Price + ", " + Stock + ");", sqlCon);

                NoRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return NoRows.ToString();
        }

        [WebMethod]
        public DataSet getSupplierName()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select SupplierName from SupplierTable", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "SupplierTable");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Supplier Name " + ex);
            }
            return ds;
        }

        [WebMethod]
        public string getSupplierId(string SupplierName)
        {
            string SupplierID = "";
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select SupplierID from SupplierTable where SupplierName = '" + SupplierName + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                Boolean records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        SupplierID = dr[0].ToString();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching Supplier Name" + ex);
            }
            return SupplierID;
        }

        [WebMethod]
        public bool UpdateStock(string DrugID, int newStock)
        {
            bool records = false;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Update DrugTable set Stock = Stock+" + newStock + "where DrugID='" + DrugID + "'", sqlCon);

                SqlDataReader dr = cmd.ExecuteReader();
                records = dr.HasRows;
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error update stock" + ex);
            }
            return records;
        }

        [WebMethod]
        public int CheckStock(string DrugID)
        {
            int Stock = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select Stock from DrugTable where DrugID= '" + DrugID + "'", sqlCon);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Stock = Convert.ToInt32(dr["Stock"]);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking stock: " + ex);
            }
            return Stock;
        }

        [WebMethod]
        public DataSet SearchDrug(string DrugID)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select * from DrugTable where DrugID= '" + DrugID + "'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "DrugTable");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching drug" + ex);
            }
            return ds;
        }

        [WebMethod]
        public string AutoOrderID()
        {
            string OrderID = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select OrderID from OrderTable", sqlCon);
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
                        OrderID = "OR00" + CTR;
                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        OrderID = "OR0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        OrderID = "OR" + CTR;
                    }
                }
                else
                {
                    OrderID = "OR001";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                OrderID = e1.ToString();
            }
            return OrderID;
        }

        [WebMethod]
        public string PlaceOrder(string OrderID, string DrugID, int Quantity)
        {
            string result = "Order placement failed";
            try
            {
                int currentStock = CheckStock(DrugID);
                if (currentStock >= Quantity)
                {
                    getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE DrugTable SET Stock = Stock - " + Quantity + " WHERE DrugID = '" + DrugID + "'", sqlCon);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {      
                        SqlCommand orderCmd = new SqlCommand("INSERT INTO OrderTable values ('" + OrderID + "','" + DrugID + "', " + Quantity + ");", sqlCon);

                        int orderRows = orderCmd.ExecuteNonQuery();
                        if (orderRows > 0)
                        {
                            result = "Order placed successfully";
                        }
                    }
                }
                else
                {
                    result = "Not enough stock available";
                }
            }
            catch (Exception ex)
            {
                result = "Error placing order: " + ex;
            }
            return result;
        }

        [WebMethod]
        public DataSet SearchDrugByName(string DrugName)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select * from DrugTable where DrugName LIKE '%" + DrugName + "%'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "DrugTable");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching drug by name" + ex);
            }
            return ds;
        }

        [WebMethod]
        public DataSet GetOrders()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand(@"
                        SELECT o.OrderID, o.DrugID, d.DrugName, CAST(d.Price AS DECIMAL(10,2)) AS Price, o.Quantity, (CAST(d.Price AS DECIMAL(10,2)) * o.Quantity) AS TotalPrice
                        FROM OrderTable o
                        JOIN DrugTable d ON o.DrugID = d.DrugID", sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "OrderTable");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving orders: " + ex);
            }
            return ds;
        }
    }
}
