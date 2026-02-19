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
            string query = "SELECT * FROM Authors";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                authors.Add(new Author
                {
                    AuthorId = Convert.ToInt32(row["AuthorId"]),
                    Name = row["Name"].ToString()
                });
            }

            return authors;
        }

        public Author GetById(int id)
        {
            string query = "SELECT * FROM Authors WHERE AuthorId = @Id";
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
                    Name = row["Name"].ToString()
                };
            }

            return null;
        }
    }
}
