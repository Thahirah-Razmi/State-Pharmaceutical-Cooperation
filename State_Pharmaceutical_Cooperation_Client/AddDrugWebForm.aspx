<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDrugWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.AddDrugWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Drug</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add Drug</h2>
            <table>
                <tr>
                    <td><h3>Drug ID</h3></td>
                    <td><asp:TextBox ID="txtDrugId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><h3>Drug Name</h3></td>
                    <td><asp:TextBox ID="txtDrugName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><h3>Supplier</h3></td>
                    <td><asp:DropDownList ID="dlSupplier" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><h3>Description</h3></td>
                    <td><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><h3>Price</h3></td>
                    <td><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
                </tr>   
                <tr>
                    <td><h3>Stock</h3></td>
                    <td><asp:TextBox ID="txtStock" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
                </tr>
            </table>
            <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
