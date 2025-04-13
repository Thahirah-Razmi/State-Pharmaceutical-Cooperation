using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        UserServiceReference.UserWebServiceSoapClient obj = new UserServiceReference.UserWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Usertype = obj.AuthenticateUser(txtUsername.Text, txtPassword.Text);

            if(Usertype == "WarehouseStaff" || Usertype == "ManufacturingPlant" || Usertype == "Pharmacy")
            {
                Session["Username"] = txtUsername.Text;
                Session["Usertype"] = Usertype;
                Response.Redirect("DashboardWebForm.aspx");
            }
            else
            {
                lblText.Text = "Incorrect username or password!";
                lblText.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
