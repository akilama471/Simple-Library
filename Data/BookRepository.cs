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
    public class BookRepository
    {
        public void Add(Book book)
        {
            string query = @"INSERT INTO Books (Title, AuthorId, PublisherId, Classification, IsReferenceOnly, BookNumber) 
                             VALUES (@Title, @AuthorId, @PublisherId, @Classification, @IsReferenceOnly, @BookNumber);
                             SELECT SCOPE_IDENTITY();";
            
            SqlParameter[] parameters = {
                new SqlParameter("@Title", book.Title),
                new SqlParameter("@AuthorId", book.AuthorId),
                new SqlParameter("@PublisherId", book.PublisherId),
                new SqlParameter("@Classification", book.Classification),
                new SqlParameter("@IsReferenceOnly", book.IsReferenceOnly),
                new SqlParameter("@BookNumber", book.BookNumber)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            book.BookId = Convert.ToInt32(result);

            // Add Copies
            if (book.Copies != null && book.Copies.Count > 0)
            {
                foreach (var copy in book.Copies)
                {
                    AddCopy(copy, book.BookId);
                }
            }
        }

        public void AddCopy(Copy copy, int bookId)
        {
            string query = "INSERT INTO Copies (BookId, CopyNumber, IsAvailable) VALUES (@BookId, @CopyNumber, @IsAvailable)";
            SqlParameter[] parameters = {
                new SqlParameter("@BookId", bookId),
                new SqlParameter("@CopyNumber", copy.CopyNumber),
                new SqlParameter("@IsAvailable", copy.IsAvailable)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            string query = @"SELECT b.*, a.Name as AuthorName, p.Name as PublisherName 
                             FROM Books b 
                             JOIN Authors a ON b.AuthorId = a.AuthorId 
                             JOIN Publishers p ON b.PublisherId = p.PublisherId";
            
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Book book = MapBookFromRow(row);
                books.Add(book);
            }

            return books;
        }

        public Book GetById(int id)
        {
            string query = @"SELECT b.*, a.Name as AuthorName, p.Name as PublisherName 
                             FROM Books b 
                             JOIN Authors a ON b.AuthorId = a.AuthorId 
                             JOIN Publishers p ON b.PublisherId = p.PublisherId 
                             WHERE b.BookId = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", id)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return MapBookFromRow(dt.Rows[0]);
            }
            return null;
        }

        private Book MapBookFromRow(DataRow row)
        {
            return new Book
            {
                BookId = Convert.ToInt32(row["BookId"]),
                Title = row["Title"].ToString(),
                BookNumber = row["BookNumber"].ToString(),
                AuthorId = Convert.ToInt32(row["AuthorId"]),
                PublisherId = Convert.ToInt32(row["PublisherId"]),
                Classification = row["Classification"].ToString(),
                IsReferenceOnly = Convert.ToBoolean(row["IsReferenceOnly"]),
                Author = new Author { AuthorId = Convert.ToInt32(row["AuthorId"]), Name = row["AuthorName"].ToString() },
                Publisher = new Publisher { PublisherId = Convert.ToInt32(row["PublisherId"]), Name = row["PublisherName"].ToString() }
            };
        }

        public List<Copy> GetCopiesByBookId(int bookId)
        {
             List<Copy> copies = new List<Copy>();
             string query = "SELECT * FROM Copies WHERE BookId = @BookId";
             SqlParameter[] parameters = { new SqlParameter("@BookId", bookId) };
             DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

             foreach(DataRow row in dt.Rows)
             {
                 copies.Add(new Copy
                 {
                     CopyId = Convert.ToInt32(row["CopyId"]),
                     BookId = Convert.ToInt32(row["BookId"]),
                     CopyNumber = row["CopyNumber"].ToString(),
                     IsAvailable = Convert.ToBoolean(row["IsAvailable"])
                 });
             }
             return copies;
        }

        public DataTable SearchBooks(string searchText, string searchType)
        {
            // Search logic. Returning DataTable for easier binding to Grid with counts
            string query = @"
                SELECT 
                    b.Title, 
                    a.Name as Author, 
                    p.Name as Publisher, 
                    b.Classification, 
                    b.IsReferenceOnly,
                    (SELECT COUNT(*) FROM Copies c WHERE c.BookId = b.BookId AND c.IsAvailable = 1) as AvailableCopies,
                    (SELECT COUNT(*) FROM Copies c WHERE c.BookId = b.BookId AND c.IsAvailable = 0) as LoanedCopies,
                    (SELECT COUNT(*) FROM Reservations r WHERE r.BookId = b.BookId) as ReservationCount
                FROM Books b
                JOIN Authors a ON b.AuthorId = a.AuthorId
                JOIN Publishers p ON b.PublisherId = p.PublisherId
                LEFT JOIN Copies cp ON b.BookId = cp.BookId
                WHERE 1=1 ";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                if (searchType == "Title")
                {
                    query += " AND b.Title LIKE @Search";
                    parameters.Add(new SqlParameter("@Search", "%" + searchText + "%"));
                }
                else if (searchType == "Author")
                {
                    query += " AND a.Name LIKE @Search";
                    parameters.Add(new SqlParameter("@Search", "%" + searchText + "%"));
                }
                else if (searchType == "CopyNumber")
                {
                    // For CopyNumber search, we need to join Copies and check
                    query += " AND cp.CopyNumber = @CopyNumber";
                     parameters.Add(new SqlParameter("@CopyNumber", searchText));
                }
            }
            
            query += " GROUP BY b.BookId, b.Title, a.Name, p.Name, b.Classification, b.IsReferenceOnly";

            return DatabaseHelper.ExecuteQuery(query, parameters.ToArray());
        }
        public Copy GetCopyByNumber(string copyNumber)
        {
            string query = @"SELECT c.CopyId, c.IsAvailable, b.IsReferenceOnly, b.BookId 
                             FROM Copies c 
                             JOIN Books b ON c.BookId = b.BookId 
                             WHERE c.CopyNumber = @CopyNumber";
            
            DataTable dt = DatabaseHelper.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@CopyNumber", copyNumber) });

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Copy
                {
                    CopyId = Convert.ToInt32(row["CopyId"]),
                    IsAvailable = Convert.ToBoolean(row["IsAvailable"]),
                    BookId = Convert.ToInt32(row["BookId"]),
                    // We can map Book.IsReferenceOnly here if we extend Copy model or just return a DTO.
                    // Ideally, Copy has a Book property.
                    Book = new Book 
                    { 
                        BookId = Convert.ToInt32(row["BookId"]),
                        IsReferenceOnly = Convert.ToBoolean(row["IsReferenceOnly"]) 
                    }
                };
            }
            return null;
        }
    }
}
