using System;
using System.Data;
using System.Web.UI;

namespace SMS
{
    public partial class TeacherReport : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTeacherReport();
            }
        }

        private void LoadTeacherReport()
        {
            try
            {
                TeacherDAL teacherDAL = new TeacherDAL();
                DataTable teachers = teacherDAL.GetAllTeachers();
                gvTeacherReport.DataSource = teachers;
                gvTeacherReport.DataBind();
            }
            catch (Exception ex)
            {
                // Handle the error (e.g., log it and show a friendly message)
            }
        }
    }
}
