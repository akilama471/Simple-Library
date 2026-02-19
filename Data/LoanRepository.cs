using SarasaviLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Data
{
    public class LoanRepository
    {
        public bool AddLoan(Loan loan)
        {
            // Transaction could be used here for data integrity
            string query = "INSERT INTO Loans (CopyId, MemberId, LoanDate, DueDate, IsReturned) VALUES (@CopyId, @MemberId, @LoanDate, @DueDate, 0)";
            SqlParameter[] parameters = {
                new SqlParameter("@CopyId", loan.CopyId),
                new SqlParameter("@MemberId", loan.MemberId),
                new SqlParameter("@LoanDate", loan.LoanDate),
                new SqlParameter("@DueDate", loan.DueDate)
            };
            
            DatabaseHelper.ExecuteNonQuery(query, parameters);

            // Update Copy availability
            string updateCopyQuery = "UPDATE Copies SET IsAvailable = 0 WHERE CopyId = @CopyId";
            DatabaseHelper.ExecuteNonQuery(updateCopyQuery, new SqlParameter[] { new SqlParameter("@CopyId", loan.CopyId) });

            return true;
        }

        public void ReturnLoan(int loanId)
        {
            // Get CopyId first
            string getCopyIdQuery = "SELECT CopyId FROM Loans WHERE LoanId = @LoanId";
            int copyId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(getCopyIdQuery, new SqlParameter[] { new SqlParameter("@LoanId", loanId) }));

            // Update Loan
            string updateLoanQuery = "UPDATE Loans SET IsReturned = 1 WHERE LoanId = @LoanId";
            DatabaseHelper.ExecuteNonQuery(updateLoanQuery, new SqlParameter[] { new SqlParameter("@LoanId", loanId) });

            // Update Copy
            string updateCopyQuery = "UPDATE Copies SET IsAvailable = 1 WHERE CopyId = @CopyId";
            DatabaseHelper.ExecuteNonQuery(updateCopyQuery, new SqlParameter[] { new SqlParameter("@CopyId", copyId) });
        }

        public List<Loan> GetActiveLoansByMember(int memberId)
        {
            List<Loan> loans = new List<Loan>();
            string query = @"SELECT l.*, c.CopyNumber, b.Title 
                             FROM Loans l 
                             JOIN Copies c ON l.CopyId = c.CopyId 
                             JOIN Books b ON c.BookId = b.BookId 
                             WHERE l.MemberId = @MemberId AND l.IsReturned = 0";

            SqlParameter[] parameters = { new SqlParameter("@MemberId", memberId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                loans.Add(new Loan
                {
                    LoanId = Convert.ToInt32(row["LoanId"]),
                    CopyId = Convert.ToInt32(row["CopyId"]),
                    MemberId = Convert.ToInt32(row["MemberId"]),
                    LoanDate = Convert.ToDateTime(row["LoanDate"]),
                    DueDate = Convert.ToDateTime(row["DueDate"]),
                    IsReturned = Convert.ToBoolean(row["IsReturned"]),
                    Copy = new Copy { 
                        CopyId = Convert.ToInt32(row["CopyId"]), 
                        CopyNumber = row["CopyNumber"].ToString(),
                        Book = new Book { Title = row["Title"].ToString() }
                    }
                });
            }
            return loans;
        }

        public int GetActiveLoanCount(int memberId)
        {
            string query = "SELECT COUNT(*) FROM Loans WHERE MemberId = @MemberId AND IsReturned = 0";
            SqlParameter[] parameters = { new SqlParameter("@MemberId", memberId) };
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
        }

        public bool HasOverdueLoans(int memberId)
        {
            string query = "SELECT COUNT(*) FROM Loans WHERE MemberId = @MemberId AND IsReturned = 0 AND DueDate < @Today";
            SqlParameter[] parameters = { 
                new SqlParameter("@MemberId", memberId),
                new SqlParameter("@Today", DateTime.Now) 
            };
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters)) > 0;
        }
        public Loan GetActiveLoanByCopyNumber(string copyNumber)
        {
            string query = @"SELECT l.LoanId, l.LoanDate, l.DueDate, m.Name as MemberName, m.NIC 
                             FROM Loans l 
                             JOIN Copies c ON l.CopyId = c.CopyId 
                             JOIN Members m ON l.MemberId = m.MemberId 
                             WHERE c.CopyNumber = @CopyNumber AND l.IsReturned = 0";
            
            DataTable dt = DatabaseHelper.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@CopyNumber", copyNumber) });

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Loan
                {
                    LoanId = Convert.ToInt32(row["LoanId"]),
                    LoanDate = Convert.ToDateTime(row["LoanDate"]),
                    DueDate = Convert.ToDateTime(row["DueDate"]),
                    Member = new Member { Name = row["MemberName"].ToString(), NIC = row["NIC"].ToString() }
                };
            }
            return null;
        }
    }
}
