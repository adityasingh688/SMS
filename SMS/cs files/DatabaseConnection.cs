using System;
using System.Configuration;

namespace SMS
{
    public static class DatabaseConnection
    {
        // Retrieves the connection string from the Web.config file
        public static string GetConnectionString()
        {
            // Attempt to retrieve the connection string
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SMSDB"]?.ConnectionString;

                // Check if the connection string is null or empty
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception("Connection string 'SchoolDB' not found in the configuration file.");
                }

                return connectionString;
            }
            catch (ConfigurationErrorsException ex)
            {
                throw new Exception("Error accessing the configuration file: " + ex.Message);
            }
        }
    }
}
