<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SMS.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>School Management System</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Welcome to the School Management System</h1>
            <div class="login-options">
                <h2>Login As</h2>
                <div class="login-buttons">
                    <asp:Button ID="btnLoginTeacher" runat="server" Text="Login as Teacher" CssClass="btn btn-primary" OnClick="btnLoginTeacher_Click" />
                    <asp:Button ID="btnLoginStudent" runat="server" Text="Login as Student" CssClass="btn btn-primary" OnClick="btnLoginStudent_Click" />
                    <asp:Button ID="btnLoginPrincipal" runat="server" Text="Login as Principal" CssClass="btn btn-primary" OnClick="btnLoginPrincipal_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
