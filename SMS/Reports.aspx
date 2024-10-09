<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="SMS.Reports" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reports</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <h1>Reports</h1>
            <div class="grid-container">
                <div class="grid-item">
                    <asp:Button ID="btnTeacherReport" runat="server" Text="Teacher Report" CssClass="btn btn-primary" OnClick="btnTeacherReport_Click" />
                </div>
                <div class="grid-item">
                    <asp:Button ID="btnStudentReport" runat="server" Text="Student Report" CssClass="btn btn-primary" OnClick="btnStudentReport_Click" />
                </div>
                <!-- Add more report options as needed -->
            </div>
        </div>
    </form>
</body>
</html>
