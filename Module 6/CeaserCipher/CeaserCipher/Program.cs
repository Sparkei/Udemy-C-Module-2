using System;

namespace CeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var plainText = "Attack at night man";
            string cipherText = "";
            Console.WriteLine($"PlainText {plainText}");
            Console.WriteLine();
            Console.WriteLine("Cipher Text");
            foreach (var item in CeaserCipher.Encrypt(plainText, 3))
            {
                cipherText = cipherText + item;
            }
            Console.WriteLine(cipherText);
            Console.WriteLine("Decrypt Text");

            foreach (var item in CeaserCipher.Decrypt(cipherText, 3))
            {
                Console.Write(item);
            }

        }
    }

    class CeaserCipher
    {
        public static char[] Encrypt(string plaintext, int shift)
        {
            char[] plainArray = plaintext.ToLower().ToCharArray();
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
                    if (letter < 'a')
                    {
                        letter = (char)(letter + 26);

                    }
                }
                cipherArray[i] = letter;
            }
            return cipherArray;

        }

        public static char[] Decrypt(string cipherText, int shift)
        {
            char[] cipherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherArray.Length];
            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = cipherArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - shift);


                    if (letter > 'z')
                    {
                        letter = (char)(letter + 26);

                    }
                    if (letter < 'a')
                    {
                        letter = (char)(letter - 26);

                    }
                }
                plainArray[i] = letter;
            }
            return plainArray;

        }

    }
}
