using System;

namespace SMS
{
    public partial class PrincipalDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Logic to set the principal's name if needed
        }

        protected void btnAddTeacher_Click(object sender, EventArgs e)
        {
            // Redirect to the Add Teacher page
            Response.Redirect("AddTeacher.aspx");
        }

        protected void btnViewReports_Click(object sender, EventArgs e)
        {
            // Redirect to the View Reports page
            Response.Redirect("ViewReports.aspx");
        }

        protected void btnManageClasses_Click(object sender, EventArgs e)
        {
            // Redirect to the Manage Classes page
            Response.Redirect("ManageClasses.aspx");
        }

        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Redirect to the Add Student page
            Response.Redirect("AddStudent.aspx");
        }
    }
}
