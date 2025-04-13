using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class RegisterWebForm : System.Web.UI.Page
    {
        UserServiceReference.UserWebServiceSoapClient obj = new UserServiceReference.UserWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Text = obj.AutoSupplierID();
        }
        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string value = obj.RegisterSupplier(txtId.Text, txtName.Text, txtUsername.Text, txtPassword.Text, txtContactNumber.Text);
            int noRecords = Int32.Parse(value);

            if (noRecords > 0)
            {
                lblText.Text = "Registration Successful!";

                Response.Redirect("LoginWebForm.aspx");
            }
            else
            {
                lblText.Text = "Registration Failed!";
            }
        }
    }
}