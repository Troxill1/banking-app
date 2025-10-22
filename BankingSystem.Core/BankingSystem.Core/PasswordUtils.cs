using System.Text;
using System.Security.Cryptography;

namespace BankingSystem.Core
{
    public static class PasswordUtils
    {
        public static string Hash(string password)
        {
            using var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public static bool Verify(string hashed, string input) => hashed == Hash(input);
    }
}
