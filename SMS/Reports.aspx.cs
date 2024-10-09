using System;
using System.Web.UI;

namespace SMS
{
    public partial class Reports : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Add any logic that should run on page load
        }

        protected void btnTeacherReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeacherReport.aspx");
        }

        protected void btnStudentReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentReport.aspx");
        }
    }
}
