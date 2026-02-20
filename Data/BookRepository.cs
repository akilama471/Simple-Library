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
            book.BookNumber = GetNextBookNumber();

            // ISBN Unique constraint is handled by Database (SQL Exception will be thrown)
            string query = @"INSERT INTO Books (Title, AuthorId, PublisherId, Classification, IsReferenceOnly, BookNumber, ISBN, Edition) 
                             VALUES (@Title, @AuthorId, @PublisherId, @Classification, @IsReferenceOnly, @BookNumber, @ISBN, @Edition);
                             SELECT SCOPE_IDENTITY();";
            
            SqlParameter[] parameters = {
                new SqlParameter("@Title", book.Title),
                new SqlParameter("@AuthorId", book.AuthorId),
                new SqlParameter("@PublisherId", book.PublisherId),
                new SqlParameter("@Classification", book.Classification),
                new SqlParameter("@IsReferenceOnly", book.IsReferenceOnly), // Legacy/Default for Book, though mostly on Copy now
                new SqlParameter("@BookNumber", book.BookNumber),
                new SqlParameter("@ISBN", (object)book.ISBN ?? DBNull.Value),
                new SqlParameter("@Edition", (object)book.Edition ?? DBNull.Value)
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            book.BookId = Convert.ToInt32(result);

            // Add Copies
            if (book.Copies != null && book.Copies.Count > 0)
            {
                // Re-generate copy numbers based on new BookNumber
                for (int i = 0; i < book.Copies.Count; i++)
                {
                    book.Copies[i].CopyNumber = $"{book.BookNumber}-{i + 1}";
                }

                foreach (var copy in book.Copies)
                {
                    AddCopy(copy, book.BookId);
                }
            }
        }

        private string GetNextBookNumber()
        {
            // ... (keep existing implementation) ...
            try
            {
                string query = "SELECT TOP 1 BookNumber FROM Books ORDER BY BookId DESC";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0 && dt.Rows[0]["BookNumber"] != DBNull.Value)
                {
                    string lastBookNumber = dt.Rows[0]["BookNumber"].ToString();
                    if (lastBookNumber.StartsWith("B") && lastBookNumber.Length > 1)
                    {
                        string numericPart = lastBookNumber.Substring(1);
                        if (int.TryParse(numericPart, out int number))
                        {
                            return $"B{(number + 1):D5}";
                        }
                    }
                }
                
                return "B00001";
            }
            catch
            {
                return "B00001"; // Fallback
            }
        }

        public void AddCopy(Copy copy, int bookId)
        {
            // Rule: Max 10 Copies Validation
            string countQuery = "SELECT COUNT(*) FROM Copies WHERE BookId = @BookId";
            int currentCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(countQuery, new SqlParameter[] { new SqlParameter("@BookId", bookId) }));

            if (currentCount >= 10)
            {
                throw new Exception("Maximum 10 copies allowed for this edition.");
            }

            string query = "INSERT INTO Copies (BookId, CopyNumber, IsAvailable, IsReferenceOnly) VALUES (@BookId, @CopyNumber, @IsAvailable, @IsReferenceOnly)";
            SqlParameter[] parameters = {
                new SqlParameter("@BookId", bookId),
                new SqlParameter("@CopyNumber", copy.CopyNumber),
                new SqlParameter("@IsAvailable", copy.IsAvailable),
                new SqlParameter("@IsReferenceOnly", copy.IsReferenceOnly)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public List<Copy> GetAllCopies()
        {
            List<Copy> copies = new List<Copy>();
            // Join Copies with Books, Authors, Publishers to get full details
            string query = @"
                SELECT 
                    c.CopyId, c.CopyNumber, c.IsAvailable, c.IsReferenceOnly as CopyRefOnly,
                    b.BookId, b.Title, b.BookNumber, b.Classification, b.ISBN, b.Edition,
                    a.AuthorId, a.Name as AuthorName,
                    p.PublisherId, p.Name as PublisherName
                FROM Copies c
                JOIN Books b ON c.BookId = b.BookId
                JOIN Authors a ON b.AuthorId = a.AuthorId
                JOIN Publishers p ON b.PublisherId = p.PublisherId";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                copies.Add(new Copy
                {
                    CopyId = Convert.ToInt32(row["CopyId"]),
                    CopyNumber = row["CopyNumber"].ToString(),
                    IsAvailable = Convert.ToBoolean(row["IsAvailable"]),
                    IsReferenceOnly = row["CopyRefOnly"] != DBNull.Value ? Convert.ToBoolean(row["CopyRefOnly"]) : false,
                    BookId = Convert.ToInt32(row["BookId"]),
                    Book = new Book
                    {
                        BookId = Convert.ToInt32(row["BookId"]),
                        Title = row["Title"].ToString(),
                        BookNumber = row["BookNumber"].ToString(),
                        ISBN = row["ISBN"].ToString(),
                        Edition = row["Edition"].ToString(),
                        Classification = row["Classification"].ToString(),
                        Author = new Author { AuthorId = Convert.ToInt32(row["AuthorId"]), Name = row["AuthorName"].ToString() },
                        Publisher = new Publisher { PublisherId = Convert.ToInt32(row["PublisherId"]), Name = row["PublisherName"].ToString() }
                    }
                });
            }
            return copies;
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            string query = @"SELECT b.*, a.Name as AuthorName, p.Name as PublisherName,
                             (SELECT COUNT(*) FROM Copies c WHERE c.BookId = b.BookId) as CopyCount
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

        // ... GetById ...

        private Book MapBookFromRow(DataRow row)
        {
            var book = new Book
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

            if (row.Table.Columns.Contains("CopyCount") && row["CopyCount"] != DBNull.Value)
            {
                book.CopyCount = Convert.ToInt32(row["CopyCount"]);
            }

            return book;
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
            string query = @"SELECT c.CopyId, c.IsAvailable, c.IsReferenceOnly, b.BookId, b.IsReferenceOnly as BookRefOnly
                             FROM Copies c 
                             JOIN Books b ON c.BookId = b.BookId 
                             WHERE c.CopyNumber = @CopyNumber";
            
            SqlParameter[] parameters = { new SqlParameter("@CopyNumber", copyNumber) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Copy
                {
                    CopyId = Convert.ToInt32(row["CopyId"]),
                    CopyNumber = copyNumber,
                    IsAvailable = Convert.ToBoolean(row["IsAvailable"]),
                    IsReferenceOnly = row["IsReferenceOnly"] != DBNull.Value ? Convert.ToBoolean(row["IsReferenceOnly"]) : false,
                    BookId = Convert.ToInt32(row["BookId"]),
                    Book = new Book 
                    { 
                        BookId = Convert.ToInt32(row["BookId"]),
                        // Legacy/Fallback mapping if needed
                        IsReferenceOnly = Convert.ToBoolean(row["BookRefOnly"]) 
                    }
                };
            }
            return null;
        }
    }
}
