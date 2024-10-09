<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalDashboard.aspx.cs" Inherits="SMS.PrincipalDashboard" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Principal Dashboard</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <h1>Welcome, Principal</h1>
            <div class="grid-container">
                <div class="grid-item">
                    <asp:Button ID="btnAddTeacher" runat="server" Text="Add Teacher" CssClass="btn btn-primary" OnClick="btnAddTeacher_Click" />
                </div>
                <div class="grid-item">
                    <asp:Button ID="btnViewReports" runat="server" Text="View Reports" CssClass="btn btn-primary" OnClick="btnViewReports_Click" />
                </div>
                <div class="grid-item">
                    <asp:Button ID="btnManageClasses" runat="server" Text="Manage Classes" CssClass="btn btn-primary" OnClick="btnManageClasses_Click" />
                </div>
                <div class="grid-item">
                    <asp:Button ID="btnAddStudent" runat="server" Text="Add Student" CssClass="btn btn-primary" OnClick="btnAddStudent_Click" />
                </div>
                <!-- Add more grid items as needed -->
            </div>
        </div>
    </form>
</body>
</html>
