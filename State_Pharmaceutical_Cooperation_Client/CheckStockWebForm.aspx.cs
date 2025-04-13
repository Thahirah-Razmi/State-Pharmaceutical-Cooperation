using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class CheckStockWebForm : System.Web.UI.Page
    {
        DrugServiceReference.DrugWebServiceSoapClient obj = new DrugServiceReference.DrugWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchDrug_Click(object sender, EventArgs e)
        {
            gvDrug.DataSource = obj.SearchDrug(txtDrugId.Text);
            gvDrug.DataBind();
        }

        protected void btnCheckStock_Click(object sender, EventArgs e)
        {
            int stock = obj.CheckStock(txtDrugId.Text);

            if (stock >= 0)
            {
                lblStock.Text = "Current stock: " + stock.ToString();
            }
            else
            {
                lblStock.Text = "Drug not found!";
            }
        }
    }
}