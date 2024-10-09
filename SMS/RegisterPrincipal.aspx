<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPrincipal.aspx.cs" Inherits="SMS.RegisterPrincipal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Principal</title>
    <link href="Styles/site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="register-container">
            <h1>Register Principal</h1>
            <div class="register-form">
                <asp:TextBox ID="txtName" runat="server" Placeholder="Full Name" CssClass="form-control" />
                <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email" CssClass="form-control" />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password" CssClass="form-control" />
                <asp:TextBox ID="txtPhone" runat="server" Placeholder="Phone Number" CssClass="form-control" />
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Placeholder="Address" CssClass="form-control" />
                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
                <asp:Label ID="lblMessage" runat="server" CssClass="text-danger" />
            </div>
        </div>
    </form>
</body>
</html>
