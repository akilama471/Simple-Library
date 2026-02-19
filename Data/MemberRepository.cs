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
    public class MemberRepository
    {
        public void Add(Member member)
        {
            string query = "INSERT INTO Members (Name, NIC, Address, Sex) VALUES (@Name, @NIC, @Address, @Sex)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", member.Name),
                new SqlParameter("@NIC", member.NIC),
                new SqlParameter("@Address", member.Address),
                new SqlParameter("@Sex", member.Sex)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public List<Member> GetAll()
        {
            List<Member> members = new List<Member>();
            string query = "SELECT * FROM Members";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                members.Add(new Member
                {
                    MemberId = Convert.ToInt32(row["MemberId"]),
                    Name = row["Name"].ToString(),
                    NIC = row["NIC"].ToString(),
                    Address = row["Address"].ToString(),
                    Sex = row["Sex"].ToString()
                });
            }

            return members;
        }

        public Member GetByNIC(string nic)
        {
            string query = "SELECT * FROM Members WHERE NIC = @NIC";
            SqlParameter[] parameters = {
                new SqlParameter("@NIC", nic)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Member
                {
                    MemberId = Convert.ToInt32(row["MemberId"]),
                    Name = row["Name"].ToString(),
                    NIC = row["NIC"].ToString(),
                    Address = row["Address"].ToString(),
                    Sex = row["Sex"].ToString()
                };
            }

            return null;
        }

        public Member GetById(int id)
        {
            string query = "SELECT * FROM Members WHERE MemberId = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", id)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Member
                {
                    MemberId = Convert.ToInt32(row["MemberId"]),
                    Name = row["Name"].ToString(),
                    NIC = row["NIC"].ToString(),
                    Address = row["Address"].ToString(),
                    Sex = row["Sex"].ToString()
                };
            }

            return null;
        }

        public bool IsNicExists(string nic)
        {
            string query = "SELECT COUNT(*) FROM Members WHERE NIC = @NIC";
            SqlParameter[] parameters = { new SqlParameter("@NIC", nic) };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
            return count > 0;
        }
    }
}
