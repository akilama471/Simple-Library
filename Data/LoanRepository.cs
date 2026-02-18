using System;
using System.Data.SqlClient;
using System.Configuration;
using SarasaviLibrary.Models;

namespace SarasaviLibrary.Data
{
    public class LoanRepository
    {
        private string connectionString;

        public LoanRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;
        }

        public void BorrowBook(int memberId, int copyId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Insert into Loans
                string sql = "INSERT INTO Loans (CopyId, MemberId, LoanDate, DueDate, IsReturned) " +
                             "VALUES (@CopyId, @MemberId, @LoanDate, @DueDate, 0)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyId", copyId);
                    cmd.Parameters.AddWithValue("@MemberId", memberId);
                    cmd.Parameters.AddWithValue("@LoanDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(14));

                    cmd.ExecuteNonQuery();
                }

                // Update copy status
                sql = "UPDATE Copies SET IsAvailable=0 WHERE CopyId=@CopyId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CopyId", copyId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
