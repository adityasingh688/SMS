using System;
using System.Web.UI;

namespace SMS
{
    public partial class AddTeacher : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string qualification = txtQualification.Text.Trim();
            string experience = txtExperience.Text.Trim();
            DateTime dateOfJoining;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username))
            {
                lblMessage.Text = "Name, Email, and Username are required.";
                return;
            }

            if (!DateTime.TryParse(txtDateOfJoining.Text.Trim(), out dateOfJoining))
            {
                lblMessage.Text = "Invalid date format.";
                return;
            }

            try
            {
                TeacherDAL teacherDAL = new TeacherDAL();
                bool result = teacherDAL.AddTeacher(name, email, phone, address, qualification, experience, dateOfJoining, username, password);

                if (result)
                {
                    lblMessage.Text = "Teacher added successfully!";
                }
                else
                {
                    lblMessage.Text = "Error adding teacher.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}
