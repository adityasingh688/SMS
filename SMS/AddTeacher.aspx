<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTeacher.aspx.cs" Inherits="SMS.AddTeacher" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Teacher</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h1>Add Teacher</h1>
            <div class="form-group">
                <label for="txtName">Name:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtPhone">Phone:</label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtAddress">Address:</label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" />
            </div>
            <div class="form-group">
                <label for="txtQualification">Qualification:</label>
                <asp:TextBox ID="txtQualification" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtExperience">Experience:</label>
                <asp:TextBox ID="txtExperience" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtDateOfJoining">Date of Joining:</label>
                <asp:TextBox ID="txtDateOfJoining" runat="server" CssClass="form-control" TextMode="Date" />
            </div>
            <div class="form-group">
                <label for="txtUsername">Username:</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" />
            </div>
            <asp:Button ID="btnSubmit" runat="server" Text="Add Teacher" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
            <asp:Label ID="lblMessage" runat="server" CssClass="message-label" />
        </div>
    </form>
</body>
</html>
