using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace State_Pharmaceutical_Cooperation_Client
{
    public partial class DashboardWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Usertype"] == null)
                {
                    Response.Redirect("LoginWebForm.aspx");
                }
                else
                {
                    string Usertype = Session["Usertype"].ToString();

                    if (Usertype == "WarehouseStaff")
                    {
                       
                    }
                    else if (Usertype == "ManufacturingPlant")
                    {
                        cardPlaceOrder.Visible = false;
                        cardViewOrders.Visible = false;
                    }
                    else if (Usertype == "Pharmacy")
                    {
                        cardAddDrug.Visible = false;
                        cardUpdateStock.Visible = false;
                        cardCheckStock.Visible = false;
                    }
                }
            }
        }

        protected void btnViewDrugs_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewDrugWebForm.aspx");
        }

        protected void btnAddDrug_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddDrugWebForm.aspx");
        }

        protected void btnUpdateStock_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStockWebForm.aspx");
        }

        protected void btnCheckStock_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckStockWebForm.aspx");
        }

        protected void btnSearchDrug_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchDrugWebForm.aspx");
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlaceOrderWebForm.aspx");
        }

        protected void btnViewOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewOrdersWebForm.aspx");
        }
    }
}
