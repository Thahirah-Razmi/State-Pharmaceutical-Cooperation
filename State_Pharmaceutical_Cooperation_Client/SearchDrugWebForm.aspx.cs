using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class SearchDrugWebForm : System.Web.UI.Page
    {
        DrugServiceReference.DrugWebServiceSoapClient obj = new DrugServiceReference.DrugWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchDrug_Click(object sender, EventArgs e)
        {
            string drugId = txtDrugId.Text.Trim();
            string drugName = txtDrugName.Text.Trim();

            if (!string.IsNullOrEmpty(drugId))
            {
                var result = obj.SearchDrug(drugId);
                DisplayResults(result);
            }
            else if (!string.IsNullOrEmpty(drugName))
            {
                var result = obj.SearchDrugByName(drugName);
                DisplayResults(result);
            }
            else
            {
                lblErrorMessage.Text = "Please enter either Drug ID or Drug Name.";
                lblErrorMessage.Visible = true;
            }
        }

        private void DisplayResults(DataSet result)
        {
            if (result.Tables[0].Rows.Count > 0)
            {
                gvDrug.DataSource = result;
                gvDrug.DataBind();
                lblErrorMessage.Visible = false;
            }
            else
            {
                gvDrug.DataSource = null;
                gvDrug.DataBind();
                lblErrorMessage.Text = "No drug found with the given criteria.";
                lblErrorMessage.Visible = true;
            }
        }
    }
}