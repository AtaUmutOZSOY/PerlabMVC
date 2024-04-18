using System;
using System.Linq;
using System.Security.Cryptography;

namespace Core.Utilities.Generators
{
    public static class PasswordGenerator
    {
        private static readonly char[] AvailableCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

        public static string GeneratePassword(int length = 12)
        {
            var random = new Random();
            var password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = AvailableCharacters[random.Next(AvailableCharacters.Length)];
            }

            return new string(password);
        }

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
