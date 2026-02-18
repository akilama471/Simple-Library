using SarasaviLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Data
{
    public class PublisherRepository
    {
        private string connectionString;

        public PublisherRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;
        }

        public bool AddPublisher(Publisher publisher, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "INSERT INTO Publishers (Name) VALUES (@Name)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", publisher.Name);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true; // success
            }
            catch (SqlException ex)
            {
                errorMessage = "Database error: " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = "Unexpected error: " + ex.Message;
                return false;
            }
        }

        public DataTable GetAllPublisher()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Publishers";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
