using System;
using System.Security.Cryptography;
using System.Text;

namespace FitnessTrackerApp.Utility
{
    public class PasswordManager
    {
       
        private PasswordManager() { }
        public static string GetSaltedHash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(password + Util.SALT_STRING);
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);
                string hashedPassword = Convert.ToBase64String(hashBytes);
                return hashedPassword;
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string hashedEnteredPassword = GetSaltedHash(enteredPassword);
            return storedHash.Equals(hashedEnteredPassword);
        }
    }
}
