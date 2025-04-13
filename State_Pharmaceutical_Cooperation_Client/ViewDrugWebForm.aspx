<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewDrugWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.ViewDrugWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Drug</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Drug List</h2>
            <asp:GridView ID="gvDrugs" runat="server" AutoGenerateColumns="True" BorderWidth="1" CellPadding="5"></asp:GridView>
        </div>
    </form>
</body>
</html>
