using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SarasaviLibrary.Models;

namespace SarasaviLibrary.Data
{
    public class MemberRepository
    {
        private string connectionString;

        public MemberRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;
        }

        public bool AddMember(Member member, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "INSERT INTO Members (Name, NIC, Address, Sex) VALUES (@Name, @NIC, @Address, @Sex)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", member.Name);
                        cmd.Parameters.AddWithValue("@NIC", member.NIC);
                        cmd.Parameters.AddWithValue("@Address", member.Address);
                        cmd.Parameters.AddWithValue("@Sex", member.Sex);

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

        public DataTable GetAllMembers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Members";
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
