<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.LoginWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            <table>
                <tr>
                    <td><h3>Username</h3></td>
                    <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="Enter your username" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><h3>Password</h3></td>
                    <td><asp:TextBox ID="txtPassword" runat="server" OnTextChanged="txtPassword_TextChanged" TextMode="Password"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Enter your password" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/></td>
                </tr>
            </table>
            <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
