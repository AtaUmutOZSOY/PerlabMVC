using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    
        public static class EncryptionHelper
        {
            private static readonly byte[] Key = Encoding.UTF8.GetBytes("32karakterUzunlugundaBirAnahtar1"); // 32 byte (256 bit)
            private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567812345678"); // 16 byte (128 bit)

            public static string Encrypt(string plainText)
            {
                using (var aes = Aes.Create())
                {
                    aes.KeySize = 256;
                    aes.Key = Key;
                    aes.IV = IV;

                    var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }

                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }


            public static string Decrypt(string cipherText)
            {
                var cipherTextBytes = Convert.FromBase64String(cipherText);

                using (var aes = Aes.Create())
                {
                    aes.KeySize = 256;
                    aes.Key = Key;
                    aes.IV = IV;

                    var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (var msDecrypt = new MemoryStream(cipherTextBytes))
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
