using System;
using System.IO;
using System.Security.Cryptography;

namespace CryptographyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DESCryptoServiceProvider key = new DESCryptoServiceProvider();
            Console.WriteLine("Enter your message:");
            var plainText = Console.ReadLine();
            var cypherTest = Encrypt(plainText, key);

            Console.WriteLine($"\nCipher Text:  {Encrypt(plainText, key)}");

            Console.WriteLine($"\nPlain Text:  {Decrypt(cypherTest, key) }");


        }

        public static string Encrypt(string Plaintext, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(Plaintext);
            sw.Flush();
            cs.FlushFinalBlock();
            return (Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length));
        }


        public static string Decrypt(string cipherText, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText));
            CryptoStream cs = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);

            return (sr.ReadToEnd());
        }
    }
}
