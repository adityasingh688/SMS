using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;

namespace SMS
{
    public partial class RegisterPrincipal : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Add any logic that should run on page load
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim(); // Ensure to hash the password in a real application
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            try
            {
                RegisterPrincipalInDb(name, email, password, phone, address);
                lblMessage.Text = "Registration successful.";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void RegisterPrincipalInDb(string name, string email, string password, string phone, string address)
        {
            string connectionString = DatabaseConnection.GetConnectionString();
            string query = "EXEC sp_RegisterPrincipal @Name, @Email, @Password, @Phone, @Address";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // Ensure to hash the password
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
