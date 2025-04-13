using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class UpdateStockWebForm : System.Web.UI.Page
    {
        DrugServiceReference.DrugWebServiceSoapClient obj = new DrugServiceReference.DrugWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdateStock_Click(object sender, EventArgs e)
        {
            obj.UpdateStock(txtDrugId.Text, Convert.ToInt32(txtStock.Text));
            gvDrug.DataSource = obj.SearchDrug(txtDrugId.Text);
            gvDrug.DataBind();
        }

        protected void btnSearchDrug_Click(object sender, EventArgs e)
        {
            gvDrug.DataSource = obj.SearchDrug(txtDrugId.Text);
            gvDrug.DataBind();
        }
    }
}