<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherReport.aspx.cs" Inherits="SMS.TeacherReport" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Report</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <h1>Teacher Report</h1>
            <asp:GridView ID="gvTeacherReport" runat="server" AutoGenerateColumns="False" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="TeacherID" HeaderText="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Phone" HeaderText="Phone" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:BoundField DataField="Qualification" HeaderText="Qualification" />
                    <asp:BoundField DataField="Experience" HeaderText="Experience" />
                    <asp:BoundField DataField="DateOfJoining" HeaderText="Date of Joining" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
