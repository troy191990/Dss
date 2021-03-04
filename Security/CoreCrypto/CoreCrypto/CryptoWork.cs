using Dss.CoreShared;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Dss.CoreCrypto
{
    public class CryptoWork : IDisposable
    {
        internal readonly ICryptoTransform _rijndaelDecryptor;
        internal readonly ICryptoTransform _rijndaelEncryptor;

        private static readonly byte[] RawSecretKey =
        {
            0x06, 0x01, 0x03, 0x13, 0x18, 0x21, 0x02, 0x013,
            0x05, 0x016, 0x14, 0x10, 0x23, 0x19, 0x24, 0x14
        };

        private CryptoWork(ICrpytoParams crpytoParams)
        {
            var passwordKey = EncodeDigest(crpytoParams.PassPhrase);

            using (var rijndael = new RijndaelManaged())
            {
                _rijndaelDecryptor = rijndael.CreateDecryptor(passwordKey, RawSecretKey);
                _rijndaelEncryptor = rijndael.CreateEncryptor(passwordKey, RawSecretKey);
            }
        }

        public static string Brent(string text, ICrpytoParams crpytoParams)
        {
            return EncryptString(text, crpytoParams);
        }

        public static string Carol(string text, ICrpytoParams crpytoParams)
        {
            return DecryptString(text, crpytoParams);
        }

        private static string EncryptString(string text, ICrpytoParams crpytoParams)
        {
            using (var crypto = new CryptoWork(crpytoParams))
            {
                return crypto.Encrypt(text);
            }
        }

        private static string DecryptString(string text, ICrpytoParams crpytoParams)
        {
            using (var crypto = new CryptoWork(crpytoParams))
            {
                return crypto.Decrypt(text);
            }
        }

        internal string Encrypt(string text)
        {
            var buffer = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(_rijndaelEncryptor.TransformFinalBlock(buffer, 0, buffer.Length));
        }

        internal string DecryptBytes(byte[] encryptedData)
        {
            var newClearData = _rijndaelDecryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(newClearData);
        }

        internal string Decrypt(string encryptedBase64)
        {
            // Bug in encoding so need to replace space with +
            encryptedBase64 = encryptedBase64.Replace(" ", "+");

            // Return the decrypted value
            return DecryptBytes(Convert.FromBase64String(encryptedBase64));
        }

        internal byte[] EncodeDigest(string text)
        {
            var data = Encoding.UTF8.GetBytes(text);
            using (var crypto = new MD5CryptoServiceProvider())
            {
                return crypto.ComputeHash(data);
            }
        }

        public void Dispose()
        {
            _rijndaelDecryptor.Dispose();
            _rijndaelEncryptor.Dispose();
        }
    }
}