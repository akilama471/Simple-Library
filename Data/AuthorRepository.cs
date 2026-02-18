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
        public class AuthorRepository
        {
            private string connectionString;

            public AuthorRepository()
            {
                connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;
            }

            public bool AddAuthor(Author author, out string errorMessage)
            {
                errorMessage = "";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string sql = "INSERT INTO Authors (Name) VALUES (@Name)";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", author.Name);

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

            public DataTable GetAllAuthors()
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Authors";
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
