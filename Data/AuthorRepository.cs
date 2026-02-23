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
    public class AuthorRepository
    {
        public void Add(Author author)
        {
            string query = "INSERT INTO Authors (Name) VALUES (@Name)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", author.Name)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public List<Author> GetAll()
        {
            List<Author> authors = new List<Author>();
            string query = @"
                SELECT 
                    a.AuthorId, 
                    a.Name,
                    a.CreatedAt,
                    a.UpdatedAt,
                    (SELECT COUNT(*) FROM Books b WHERE b.AuthorId = a.AuthorId) AS BookCount 
                FROM Authors a";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                authors.Add(new Author
                {
                    AuthorId = Convert.ToInt32(row["AuthorId"]),
                    Name = row["Name"].ToString(),
                    BookCount = Convert.ToInt32(row["BookCount"]),
                    CreatedAt = row["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(row["CreatedAt"]) : DateTime.MinValue,
                    UpdatedAt = row["UpdatedAt"] != DBNull.Value ? Convert.ToDateTime(row["UpdatedAt"]) : DateTime.MinValue
                });
            }

            return authors;
        }

        public void Update(Author author)
        {
            string query = "UPDATE Authors SET Name = @Name, UpdatedAt = GETDATE() WHERE AuthorId = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", author.Name),
                new SqlParameter("@Id", author.AuthorId)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Authors WHERE AuthorId = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", id)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public Author GetById(int id)
        {
            string query = @"
                SELECT 
                    a.AuthorId, 
                    a.Name,
                    a.CreatedAt,
                    a.UpdatedAt,
                    (SELECT COUNT(*) FROM Books b WHERE b.AuthorId = a.AuthorId) AS BookCount 
                FROM Authors a 
                WHERE a.AuthorId = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", id)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Author
                {
                    AuthorId = Convert.ToInt32(row["AuthorId"]),
                    Name = row["Name"].ToString(),
                    BookCount = Convert.ToInt32(row["BookCount"]),
                    CreatedAt = row["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(row["CreatedAt"]) : DateTime.MinValue,
                    UpdatedAt = row["UpdatedAt"] != DBNull.Value ? Convert.ToDateTime(row["UpdatedAt"]) : DateTime.MinValue
                };
            }

            return null;
        }
    }
}
