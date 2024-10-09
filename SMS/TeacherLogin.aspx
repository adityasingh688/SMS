<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherLogin.aspx.cs" Inherits="SMS.TeacherLogin" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Login</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h1>Teacher Login</h1>

            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <br />

            <label for="txtUsername">Username:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />

            <label for="txtPassword">Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />

            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
