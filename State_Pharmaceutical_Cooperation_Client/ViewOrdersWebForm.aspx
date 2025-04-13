<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrdersWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.ViewOrdersWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Orders</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Orders List</h2>
        <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="true" CssClass="table"/>
        </div>
    </form>
</body>
</html>
