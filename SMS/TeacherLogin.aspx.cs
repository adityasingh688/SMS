using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SMS
{
    public partial class TeacherLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty; // Clear the message on page load
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter both username and password.";
                return;
            }

            // Database connection and validation using stored procedure
            try
            {
                using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("ValidateTeacherLogin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // Plain text password

                        // Execute the stored procedure and check if any record is returned
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Store username in session for future reference
                            Session["TeacherUsername"] = username;
                            Response.Redirect("TeacherDashboard.aspx");
                        }
                        else
                        {
                            lblMessage.Text = "Invalid username or password.";
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
