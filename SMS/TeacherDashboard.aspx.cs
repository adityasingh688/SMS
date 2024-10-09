using System;

namespace SMS
{
    public partial class TeacherDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Assuming you set the teacher's name in the session during login
                lblTeacherName.Text = Session["TeacherName"]?.ToString() ?? "Teacher";
            }
        }

        protected void btnViewSchedule_Click(object sender, EventArgs e)
        {
            // Logic to view schedule (e.g., redirect to schedule page)
            Response.Redirect("ViewSchedule.aspx");
        }

        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Redirect to the Add Student page
            Response.Redirect("AddStudent.aspx");
        }

        protected void btnViewReports_Click(object sender, EventArgs e)
        {
            // Logic to view reports (e.g., redirect to reports page)
            Response.Redirect("ViewReports.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Logic to log out the user
            Session.Clear(); // Clear session
            Response.Redirect("Login.aspx"); // Redirect to login page
        }
    }
}
