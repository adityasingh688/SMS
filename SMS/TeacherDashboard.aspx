<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherDashboard.aspx.cs" Inherits="SMS.TeacherDashboard" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Dashboard</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <h1>Welcome, <asp:Label ID="lblTeacherName" runat="server" Text="Teacher"></asp:Label></h1>

            <div class="grid-container">
                <div class="grid-item">
                    <asp:Button ID="btnViewSchedule" runat="server" Text="View Schedule" CssClass="btn btn-primary" OnClick="btnViewSchedule_Click" />
                </div>
                <div class="grid-item">
                    <asp:Button ID="btnAddStudent" runat="server" Text="Add Student" CssClass="btn btn-primary" OnClick="btnAddStudent_Click" />
                </div>
                <div class="grid-item">
                    <asp:Button ID="btnViewReports" runat="server" Text="View Reports" CssClass="btn btn-primary" OnClick="btnViewReports_Click" />
                </div>
                <div class="grid-item">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-primary" OnClick="btnLogout_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
