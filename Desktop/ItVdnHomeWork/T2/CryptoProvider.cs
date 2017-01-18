using System;
using System.Security.Cryptography;
using System.Text;

namespace T2
{
    public class CryptoProvider
    {
        public static string GetMd5Hash(string p)
        {
            var md5Provider = new MD5CryptoServiceProvider();
            byte[] hashCode = md5Provider.ComputeHash(Encoding.Default.GetBytes(p));
            return BitConverter.ToString(hashCode).ToLower().Replace("-", "");
        }
    }
}