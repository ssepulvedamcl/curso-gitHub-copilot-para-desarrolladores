// ⚠️ Hash inseguro con MD5 en C#

using System;
using System.Security.Cryptography;
using System.Text;

class InsecureMD5Example
{
    static void Main(string[] args)
    {
        string password = "miContraseñaSuperSecreta";
        string hashedPassword = GetMD5Hash(password);
        Console.WriteLine("MD5 hash inseguro de la contraseña: " + hashedPassword);
    }

    static string GetMD5Hash(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
