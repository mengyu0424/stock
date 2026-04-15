using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp.Other
{
    public class PublicFun
    {
        /// <summary>
        /// string加密MD5
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToMD5(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // 转成32位大写字符串
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}