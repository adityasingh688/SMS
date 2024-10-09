using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;

namespace SMS
{
    public partial class PrincipalLogin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Add any logic that should run on page load
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (AuthenticatePrincipal(email, password))
            {
                // Redirect to the principal dashboard or another page
                Response.Redirect("PrincipalDashboard.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid email or password.";
            }
        }

        private bool AuthenticatePrincipal(string email, string password)
        {
            bool isAuthenticated = false;
            string connectionString = DatabaseConnection.GetConnectionString();
            string query = "EXEC sp_PrincipalLogin @Email, @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // Ensure to hash the password in a real application

                    conn.Open();
                    int userExists = (int)cmd.ExecuteScalar();
                    isAuthenticated = userExists > 0;
                }
            }

            return isAuthenticated;
        }
    }
}
