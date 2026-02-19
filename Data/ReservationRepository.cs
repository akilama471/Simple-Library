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
    public class ReservationRepository
    {
        public void Add(Reservation reservation)
        {
            string query = "INSERT INTO Reservations (BookId, MemberId, ReservationDate) VALUES (@BookId, @MemberId, @ReservationDate)";
            SqlParameter[] parameters = {
                new SqlParameter("@BookId", reservation.BookId),
                new SqlParameter("@MemberId", reservation.MemberId),
                new SqlParameter("@ReservationDate", reservation.ReservationDate)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public Reservation GetOldestReservation(int bookId)
        {
            string query = "SELECT TOP 1 * FROM Reservations WHERE BookId = @BookId ORDER BY ReservationDate ASC";
            SqlParameter[] parameters = { new SqlParameter("@BookId", bookId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Reservation
                {
                    ReservationId = Convert.ToInt32(row["ReservationId"]),
                    BookId = Convert.ToInt32(row["BookId"]),
                    MemberId = Convert.ToInt32(row["MemberId"]),
                    ReservationDate = Convert.ToDateTime(row["ReservationDate"])
                };
            }
            return null;
        }

        public void Remove(int reservationId)
        {
            string query = "DELETE FROM Reservations WHERE ReservationId = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", reservationId) };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
        public Reservation GetOldestReservationByCopyNumber(string copyNumber)
        {
             // First get BookId from CopyNumber
             string queryBookId = "SELECT BookId FROM Copies WHERE CopyNumber = @CopyNumber";
             object result = DatabaseHelper.ExecuteScalar(queryBookId, new SqlParameter[] { new SqlParameter("@CopyNumber", copyNumber) });
             
             if (result != null)
             {
                 int bookId = Convert.ToInt32(result);
                 return GetOldestReservation(bookId);
             }
             return null;
        }
    }
}
