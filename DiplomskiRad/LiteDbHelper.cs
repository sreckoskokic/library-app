using LiteDB;
using System.IO; 
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms; 

namespace DiplomskiRad
{
    public static class LiteDbHelper
    {
        public static string DbPath = Path.Combine(Application.StartupPath, "MojProjekat.db");

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}