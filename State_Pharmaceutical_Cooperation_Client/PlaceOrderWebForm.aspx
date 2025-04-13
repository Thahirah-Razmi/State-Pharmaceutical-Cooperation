<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceOrderWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.PlaceOrderWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Place Order</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Place Order</h2>
            <table>
                <tr>
                    <td><h3>Order ID</h3></td>
                    <td><asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><h3>Drug</h3></td>
                    <td><asp:DropDownList ID="dlDrug" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><h3>Quantity</h3></td>
                    <td><asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnPlaceOrdert" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click" /></td>
                </tr>
            </table>
            <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
