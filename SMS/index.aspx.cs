using System;
using System.Web.UI;

namespace SMS
{
    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLoginTeacher_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("TeacherLogin.aspx");
        }

        protected void btnLoginStudent_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("StudentLogin.aspx");
        }

        protected void btnLoginPrincipal_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("PrincipalLogin.aspx");
        }
    }
}
