using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SMS
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null || !(Session["UserRole"].ToString() == "Teacher" || Session["UserRole"].ToString() == "Principal"))
            {
                Response.Redirect("AccessDenied.aspx"); // Redirect to an access denied page
            }
        }


        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string className = txtClass.Text.Trim();
            string section = txtSection.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please fill in all required fields.";
                return;
            }

            // Add student to the database
            try
            {
                using (var conn = new SqlConnection(DatabaseConnection.GetConnectionString()))
                {
                    conn.Open();
                    string query = "INSERT INTO Students (Name, Username, Password, Class, Section) VALUES (@Name, @Username, @Password, @Class, @Section)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Class", className);
                        cmd.Parameters.AddWithValue("@Section", section);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            lblMessage.Text = "Student added successfully.";
                        }
                        else
                        {
                            lblMessage.Text = "Error adding student.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}
