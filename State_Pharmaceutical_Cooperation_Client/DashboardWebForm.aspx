<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashboardWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.DashboardWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SPC Dashboard</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>SPC Dashboard</h2>

            <div class="dashboard-container">
                <div class="card" id="cardViewDrugs" runat="server">
                    <h3>View Drugs</h3>
                    <asp:Button ID="btnViewDrugs" runat="server" Text="View Drugs" CssClass="btn" OnClick="btnViewDrugs_Click" />
                </div>

                <div class="card" id="cardAddDrug" runat="server">
                    <h3>Add Drug</h3>
                    <asp:Button ID="btnAddDrug" runat="server" Text="Add Drug" CssClass="btn" OnClick="btnAddDrug_Click" />
                </div>

                <div class="card" id="cardUpdateStock" runat="server">
                    <h3>Update Stock</h3>
                    <asp:Button ID="btnUpdateStock" runat="server" Text="Update Stock" CssClass="btn" OnClick="btnUpdateStock_Click" />
                </div>

                <div class="card" id="cardCheckStock" runat="server">
                    <h3>Check Stock</h3>
                    <asp:Button ID="btnCheckStock" runat="server" Text="Check Stock" CssClass="btn" OnClick="btnCheckStock_Click" />
                </div>

                <div class="card" id="cardSearchDrug" runat="server">
                    <h3>Search for a Drug</h3>
                    <asp:Button ID="btnSearchDrug" runat="server" Text="Search Drug" CssClass="btn" OnClick="btnSearchDrug_Click" />
                </div>

                <div class="card" id="cardPlaceOrder" runat="server">
                    <h3>Place Order</h3>
                    <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" CssClass="btn" OnClick="btnPlaceOrder_Click" />
                </div>

                <div class="card" id="cardViewOrders" runat="server">
                    <h3>View Orders</h3>
                    <asp:Button ID="btnViewOrders" runat="server" Text="View Orders" CssClass="btn" OnClick="btnViewOrders_Click" />
               </div>
            </div>
        </div>
    </form>
</body>
</html>
