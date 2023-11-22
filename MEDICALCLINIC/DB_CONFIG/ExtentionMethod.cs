using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace MEDICALCLINIC.DB_CONFIG
{




    public static class ExtentionMethod
    {
        private static string hash = "@#$S@bhyAndBasem";
        public static string Encrypt(this string Data)
        {
            byte[] data = UnicodeEncoding.UTF8.GetBytes(Data);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {

                    ICryptoTransform transform = triple.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

                    return Convert.ToBase64String(result, 0, result.Length);
                }
            }
        }

        public static string Decrypt(this string Data)
        {
            byte[] data = Convert.FromBase64String(Data);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {

                    ICryptoTransform transform = triple.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return UnicodeEncoding.UTF8.GetString(result);
                }
            }
        }

        public static string ToDate(this DateTime? x)
        {
            if (x == null) return "";

            return x.Value.ToString("yyyy/M/d");
        }
        public static string ToDisplay(this Enum x)
        {
            var c = x.GetType().GetMember(x.ToString()).First();
            return c.GetCustomAttributes<DisplayAttribute>() != null ? c.GetCustomAttribute<DisplayAttribute>().Name : c.Name;

        }
    }

}