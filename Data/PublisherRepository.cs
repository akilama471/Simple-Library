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
    public class PublisherRepository
    {
        public void Add(Publisher publisher)
        {
            string query = "INSERT INTO Publishers (Name) VALUES (@Name)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", publisher.Name)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public List<Publisher> GetAll()
        {
            List<Publisher> publishers = new List<Publisher>();
            string query = @"
                SELECT 
                    p.PublisherId, 
                    p.Name,
                    p.CreatedAt,
                    p.UpdatedAt,
                    (SELECT COUNT(*) FROM Books b WHERE b.PublisherId = p.PublisherId) AS BookCount 
                FROM Publishers p";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                publishers.Add(new Publisher
                {
                    PublisherId = Convert.ToInt32(row["PublisherId"]),
                    Name = row["Name"].ToString(),
                    BookCount = Convert.ToInt32(row["BookCount"]),
                    CreatedAt = row["CreatedAt"] != DBNull.Value ? Convert.ToDateTime(row["CreatedAt"]) : DateTime.MinValue,
                    UpdatedAt = row["UpdatedAt"] != DBNull.Value ? Convert.ToDateTime(row["UpdatedAt"]) : DateTime.MinValue
                });
            }

            return publishers;
        }

        public Publisher GetById(int id)
        {
            string query = @"
                SELECT 
                    p.PublisherId, 
                    p.Name,
                    p.CreatedAt,
                    p.UpdatedAt,
                    (SELECT COUNT(*) FROM Books b WHERE b.PublisherId = p.PublisherId) AS BookCount 
                FROM Publishers p 
                WHERE p.PublisherId = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", id)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Publisher
                {
                    PublisherId = Convert.ToInt32(row["PublisherId"]),
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
