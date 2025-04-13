<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchDrugWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.SearchDrugWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Drug</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Search for a drug</h2>
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
                    <td><asp:Button ID="btnSearchDrug" runat="server" Text="Search Drug" OnClick="btnSearchDrug_Click" /></td>
                </tr>
                <asp:GridView ID="gvDrug" runat="server"></asp:GridView>
                <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label>
            </table>
        </div>
    </form>
</body>
</html>
