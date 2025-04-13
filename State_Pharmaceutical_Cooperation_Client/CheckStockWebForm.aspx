<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckStockWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.CheckStockWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Check Stock</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Enter the Drug ID to check for the stock</h2>
            <table>
                <tr>
                    <td><h3>Drug ID</h3></td>
                    <td><asp:TextBox ID="txtDrugId" runat="server"></asp:TextBox></td>
                    <td><asp:Button ID="btnSearchDrug" runat="server" Text="Search Drug" OnClick="btnSearchDrug_Click" /></td>
                </tr>
                <tr>
                    <td><h3>Current Stock</h3></td>
                    <td><asp:Label ID="lblStock" runat="server"></asp:Label></td>
                    <td><asp:Button ID="btnCheckStock" runat="server" Text="Check Stock" OnClick="btnCheckStock_Click" /></td>
                </tr>
                <asp:GridView ID="gvDrug" runat="server"></asp:GridView>
            </table>
        </div>
    </form>
</body>
</html>
