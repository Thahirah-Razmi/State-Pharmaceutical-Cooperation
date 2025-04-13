using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class PlaceOrderWebForm : System.Web.UI.Page
    {
        DrugServiceReference.DrugWebServiceSoapClient obj = new DrugServiceReference.DrugWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = obj.AutoOrderID();

            if (!IsPostBack)
            {
                DataSet ds = obj.getDrugName();

                dlDrug.DataSource = ds;
                dlDrug.DataBind();

                dlDrug.DataValueField = "DrugName";
                dlDrug.DataBind();
            }
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            String DrugID = obj.getDrugId(dlDrug.Text);
            string result = obj.PlaceOrder(txtOrderId.Text, DrugID, Int32.Parse(txtQuantity.Text));

            lblText.Text = result;
        }
    }
}