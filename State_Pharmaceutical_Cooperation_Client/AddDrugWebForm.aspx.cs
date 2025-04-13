using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class AddDrugWebForm : System.Web.UI.Page
    {
        DrugServiceReference.DrugWebServiceSoapClient obj = new DrugServiceReference.DrugWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDrugId.Text = obj.AutoDrugID();

            if (!IsPostBack)
            {
                DataSet ds = obj.getSupplierName();

                dlSupplier.DataSource = ds;
                dlSupplier.DataBind();

                dlSupplier.DataValueField = "SupplierName";
                dlSupplier.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String SupplierID = obj.getSupplierId(dlSupplier.Text);
            string value = obj.insertDrug(txtDrugId.Text, txtDrugName.Text, SupplierID, txtDescription.Text, txtPrice.Text, txtStock.Text);
            int record = Int32.Parse(value);
            if (record > 0)
            {
                lblText.Text = "Drug Added";
            }
            else
            {
                lblText.Text = "Drug Not Added";
            }
        }
    }
}