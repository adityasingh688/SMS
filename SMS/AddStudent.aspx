<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="SMS.AddStudent" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Student</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="add-student-container">
            <h1>Add Student</h1>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <br />

            <label for="txtName">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />

            <label for="txtUsername">Username:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />

            <label for="txtPassword">Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />

            <label for="txtClass">Class:</label>
            <asp:TextBox ID="txtClass" runat="server"></asp:TextBox>
            <br />

            <label for="txtSection">Section:</label>
            <asp:TextBox ID="txtSection" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="btnAddStudent" runat="server" Text="Add Student" OnClick="btnAddStudent_Click" CssClass="btn" />
        </div>
    </form>
</body>
</html>
