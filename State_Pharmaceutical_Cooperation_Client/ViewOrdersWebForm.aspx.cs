using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class ViewOrdersWebForm : System.Web.UI.Page
    {
        DrugServiceReference.DrugWebServiceSoapClient obj = new DrugServiceReference.DrugWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadOrders();
            }
        }
        private void LoadOrders()
        {
            DataSet ds = obj.GetOrders();

            if (ds != null && ds.Tables.Count > 0)
            {
                gvOrders.DataSource = ds;
                gvOrders.DataBind();
            }
        }
    }
}
