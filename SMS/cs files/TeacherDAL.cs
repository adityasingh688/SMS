using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SMS
{
    public class TeacherDAL
    {
        private string connectionString = DatabaseConnection.GetConnectionString();

        // Add a new teacher
        public bool AddTeacher(string name, string email, string phone, string address, string qualification, string experience, DateTime dateOfJoining, string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddTeacher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Qualification", qualification);
                    cmd.Parameters.AddWithValue("@Experience", experience);
                    cmd.Parameters.AddWithValue("@DateOfJoining", dateOfJoining);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Remove a teacher
        public bool RemoveTeacher(int teacherID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_RemoveTeacher", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TeacherID", teacherID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // Get all teachers
        public DataTable GetAllTeachers()
        {
            DataTable teachersTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAllTeachers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(teachersTable);
                    }
                }
            }

            return teachersTable;
        }

        // Authenticate teacher
        public bool AuthenticateTeacher(string username, string password)
        {
            bool isAuthenticated = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AuthenticateTeacher", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        isAuthenticated = Convert.ToBoolean(result);
                    }
                }
            }

            return isAuthenticated;
        }
    }
}
