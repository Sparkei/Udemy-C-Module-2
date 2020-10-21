using System;
using System.IO;

namespace Assignment_9
{
    class Program
    {
        static void Main(string[] args)
        {

            ModeSelect();

        }
        #region ModeSelect
        private static void ModeSelect()
        {
            string input;
            string filePath = string.Empty;
            string fileName = string.Empty;
            string cipherText = string.Empty;
            int shift = 0;
            StreamReader sr = default;

            do
            {
                input = WelcomeMessage();

                if (input == "encrypt")
                {
                    Encrypt(out _, out cipherText, out shift);
                }

                if (input == "decrypt")
                {
                    Decrypt(out filePath, out fileName, ref cipherText, out shift, ref sr);
                }


            }
            while (input.ToLower() != "exit");
            AppMessage("Thank you for using caesar cipher app.\n");
        }

        #endregion

        #region WelcomeMessage 
        private static string WelcomeMessage()
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose mode, type 'encrpyt', 'decrypt' or 'exit'");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = defaultColor;
            string userChoose = Console.ReadLine();
            return userChoose;
        }
        #endregion

        #region Error Message
        private static void ErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        #endregion

        #region App Message
        private static void AppMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #region Encrypt 
        private static void Encrypt(out string plainText, out string cipherText, out int shift)
        {
            AppMessage("Welcome to encryption mode \nEnter message to encrypt");
            plainText = Console.ReadLine();
            shift = 0; cipherText = string.Empty;
            if (plainText != "")
            {
                try
                {
                    AppMessage("Enter the shift");
                    shift = int.Parse(Console.ReadLine());

                    if (shift <= 26 && shift > 0)
                    {
                        AppMessage("Cipher is");

                        cipherText = new string(CaesarCipher.Encrypt(plainText, shift));
                        Console.WriteLine(cipherText);
                    }
                    else
                    {
                        ErrorMessage("Enter a number between 1 to 26");
                    }
                }
                catch (Exception e)
                {
                    ErrorMessage(e.Message);
                }
            }
            else
            {
                ErrorMessage("Invalid input");
            }
        }
        #endregion

        #region Perform Decrypt Operation
        private static void Decrypt(out string filePath, out string fileName, ref string cipherText, out int shift, ref StreamReader sr)
        {
            shift = 0; fileName = string.Empty;
            AppMessage("Welcome to decryption mode \nEnter the path of file to decrypt");
            filePath = Console.ReadLine();

            if (filePath != "")
            {
                AppMessage("Enter file name");
                fileName = Console.ReadLine();
                if (fileName != "")
                {
                    filePath = filePath + "\\" + fileName;

                    AppMessage("Enter the shift");

                    try
                    {
                        shift = int.Parse(Console.ReadLine());
                        if (shift <= 26 && shift > 0)
                        {
                            sr = new System.IO.StreamReader(filePath);
                            cipherText = sr.ReadToEnd();

                            cipherText = new string(CaesarCipher.Decrypt(cipherText, shift));
                            AppMessage("Cipher is");
                            Console.WriteLine(cipherText);

                            sr.Close();
                        }
                        else
                        {
                            ErrorMessage("Enter a number between 1 to 26");
                        }

                    }
                    catch (Exception e)
                    {
                        ErrorMessage(e.Message);
                    }
                }
                else
                {
                    ErrorMessage("File name cannot be empty");
                }
            }
            else
            {
                ErrorMessage("Path is invalid");
            }
        }
        #endregion
    }

    class CaesarCipher
    {
        #region Caesar Cipher Encryption
        public static char[] Encrypt(string plainText, int shift)
        {
            char[] plainArray = plainText.ToLower().ToCharArray();
            char[] cipherArray = new char[plainArray.Length];

            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = plainArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    cipherArray[i] = letter;
                }
            }
            return cipherArray;
        }
        #endregion

        #region Caesar Cipher Decryption
        public static char[] Decrypt(string cipherText, int shift)
        {
            char[] cipherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherText.Length];

            for (int i = 0; i < cipherArray.Length; i++)
            {
                char letter = cipherArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    plainArray[i] = letter;
                }
            }
            return plainArray;
        }
        #endregion
    }
}
