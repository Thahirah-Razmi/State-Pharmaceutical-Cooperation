<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterWebForm.aspx.cs" Inherits="State_Pharmaceutical_Cooperation_Client.RegisterWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Register</h2>
            <table>
                <tr>
                    <td><h3>ID</h3></td>
                    <td><asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><h3>Name</h3></td>
                    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Name can't be blank" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><h3>Username</h3></td>
                    <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="Username can't be blank" ControlToValidate="txtUsername" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><h3>Password</h3></td>
                    <td><asp:TextBox ID="txtPassword" runat="server" OnTextChanged="txtPassword_TextChanged" TextMode="Password"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Password can't be blank" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><h3>Confirm Password</h3></td>
                    <td><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ErrorMessage="Confirm password can't be blank" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:CompareValidator ID="cvConfirmPassword" runat="server" ErrorMessage="Password and confirm password should match" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:CompareValidator></td>
                </tr>
                <tr>
                    <td><h3>Contact Number</h3></td>
                    <td><asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="rfvContactNumber" runat="server" ErrorMessage="Contact number can't be blank" ControlToValidate="txtContactNumber" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    <td><asp:RegularExpressionValidator ID="revContactNumber" runat="server" ErrorMessage="Enter a valid contact number" ControlToValidate="txtContactNumber" ForeColor="Red" ValidationExpression="^\+?\d{10,15}$"></asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
                </tr>
            </table>
            <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
