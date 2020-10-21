using System;

namespace ConsoleColors
{
    class Program
    {
        static void Main(string[] args)
        {
            string greenmessage = "This is the GREEN message";
            string bluemessage = "This is the BLUE message";
            string redMessage = "This is the RED message";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(greenmessage);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(bluemessage);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(redMessage);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
