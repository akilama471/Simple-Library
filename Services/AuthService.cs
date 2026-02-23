using SarasaviLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SarasaviLibrary.Services
{
    public static class AuthService
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string password, string hash)
        {
            string hashOfInput = HashPassword(password);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }

        public static bool ValidateLogin(string username, string password)
        {
            try
            {
                string query = "SELECT PasswordHash FROM Admins WHERE Username = @Username";
                SqlParameter[] parameters = { new SqlParameter("@Username", username) };
                
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                
                if (dt.Rows.Count > 0)
                {
                    string storedHash = dt.Rows[0]["PasswordHash"].ToString();
                    bool isValid = VerifyPassword(password, storedHash);
                    
                    if (!isValid)
                    {
                        System.Diagnostics.Debug.WriteLine($"Login failed: Password mismatch for user '{username}'");
                    }
                    return isValid;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Login failed: User '{username}' not found in Admins table.");
                }
            }
            catch (Exception ex)
            {
                // Rethrow with more context to help debugging
                throw new Exception($"Database error during login: {ex.Message}", ex);
            }
            
            return false;
        }
    }
}
