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
            member.UserNumber = GetNextUserNumber();
            string query = "INSERT INTO Members (Name, NIC, Address, Sex, UserNumber) VALUES (@Name, @NIC, @Address, @Sex, @UserNumber)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", member.Name),
                new SqlParameter("@NIC", member.NIC),
                new SqlParameter("@Address", member.Address),
                new SqlParameter("@Sex", member.Sex),
                new SqlParameter("@UserNumber", member.UserNumber)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public void Update(Member member)
        {
            string query = "UPDATE Members SET Name = @Name, NIC = @NIC, Address = @Address, Sex = @Sex WHERE MemberId = @MemberId";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", member.Name),
                new SqlParameter("@NIC", member.NIC),
                new SqlParameter("@Address", member.Address),
                new SqlParameter("@Sex", member.Sex),
                new SqlParameter("@MemberId", member.MemberId)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int memberId)
        {
            string query = "DELETE FROM Members WHERE MemberId = @MemberId";
            SqlParameter[] parameters = {
                new SqlParameter("@MemberId", memberId)
            };
            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        private string GetNextUserNumber()
        {
            try
            {
                // Get the last inserted UserNumber
                // Assuming UserNumber is in format Mxxxxx and we want the max one. 
                // However, doing MAX(UserNumber) on strings might give M9 before M10. 
                // Better to order by length then value, or just substring.
                // For simplicity and expected format M00001, standard string max is okay if length is fixed, 
                // but let's be safer by getting the latest MemberId or similar if possible.
                // Actually, let's just use the count or max parse.
                string query = "SELECT TOP 1 UserNumber FROM Members ORDER BY MemberId DESC";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0 && dt.Rows[0]["UserNumber"] != DBNull.Value)
                {
                    string lastUserNumber = dt.Rows[0]["UserNumber"].ToString();
                    if (lastUserNumber.StartsWith("M") && lastUserNumber.Length > 1)
                    {
                        string numericPart = lastUserNumber.Substring(1);
                        if (int.TryParse(numericPart, out int number))
                        {
                            return $"M{(number + 1):D5}";
                        }
                    }
                }
                
                return "M00001";
            }
            catch
            {
                return "M00001"; // Fallback
            }
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
                    Sex = row["Sex"].ToString(),
                    UserNumber = row["UserNumber"] != DBNull.Value ? row["UserNumber"].ToString() : string.Empty
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
                    Sex = row["Sex"].ToString(),
                    UserNumber = row["UserNumber"] != DBNull.Value ? row["UserNumber"].ToString() : string.Empty
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
                    Sex = row["Sex"].ToString(),
                    UserNumber = row["UserNumber"] != DBNull.Value ? row["UserNumber"].ToString() : string.Empty
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
