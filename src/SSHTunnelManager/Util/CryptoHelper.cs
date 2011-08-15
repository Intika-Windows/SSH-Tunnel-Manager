using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SSHTunnelManager.Util
{
    /// <summary>
    /// Helper class for System.Security.Cryptography algorithms. 
    /// Gives an easy way to encrypt and decrypt data (strings or streams) with password.
    /// Using algorithm Rijndael with 256 bits key and 128 bits block size.
    /// Key creating with password and salt, using Rfc 2898.
    /// </summary>
    public class CryptoHelper
    {
        private static readonly byte[] _salt = Encoding.ASCII.GetBytes("o6816642kbM7c5");
        
        public static string EncryptStringAes(string text, string password)
        {
            var inStream = text.ToMemoryStream();
            var outStream = new MemoryStream();

            EncryptAes(inStream, outStream, password);

            var result = Convert.ToBase64String(outStream.ToArray());
            return result;
        }

        public static string DecryptStringAes(string base64String, string password)
        {
            // in
            var bytes = Convert.FromBase64String(base64String);
            var inStream = new MemoryStream();
            inStream.Write(bytes, 0, bytes.Length);
            inStream.Seek(0, SeekOrigin.Begin);

            //out
            var outStream = new MemoryStream();

            DecryptAes(inStream, outStream, password);

            var result = Encoding.UTF8.GetString(outStream.ToArray());
            return result;
        }

        public static void EncryptAes(Stream inStream, Stream outStream, string password)
        {
            if (inStream == null) throw new ArgumentNullException("inStream");
            if (outStream == null) throw new ArgumentNullException("outStream");
            if (password == null) throw new ArgumentNullException("password");

            // generate the key from the shared secret and the salt
            using (var key = new Rfc2898DeriveBytes(password, _salt))
            using (var aesAlg = new RijndaelManaged())
            {
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                using (var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                using (var csEncrypt = new CryptoStream(outStream, encryptor, CryptoStreamMode.Write))
                {
                    inStream.CopyTo(csEncrypt);
                }
            }
        }

        public static void DecryptAes(Stream inStream, Stream outStream, string password)
        {
            if (inStream == null) throw new ArgumentNullException("inStream");
            if (outStream == null) throw new ArgumentNullException("outStream");
            if (password == null) throw new ArgumentNullException("password");

            // generate the key from the shared secret and the salt
            using (var key = new Rfc2898DeriveBytes(password, _salt))
            using (var aesAlg = new RijndaelManaged())
            {
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                using (var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                using (var csEncrypt = new CryptoStream(inStream, decryptor, CryptoStreamMode.Read))
                {
                    csEncrypt.CopyTo(outStream);
                }
            }
        }
    }
}
