<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalLogin.aspx.cs" Inherits="SMS.PrincipalLogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Principal Login</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Principal Login</h1>
            <div class="login-section">
                <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email" CssClass="form-control" />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password" CssClass="form-control" />
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                <asp:Label ID="lblMessage" runat="server" CssClass="text-danger" />
            </div>
        </div>
    </form>
</body>
</html>
