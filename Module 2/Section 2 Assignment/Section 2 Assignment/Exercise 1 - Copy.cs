using System;
using System.Text.RegularExpressions;
namespace Section_2_Assignment
{
    class Solution2
    {
        static void Main(string[] args)
        {
            string yourname;
            yourname = "";
            Console.WriteLine("What is your name");
            yourname = Console.ReadLine();
            while (!Regex.IsMatch(yourname, @"^[\p{L}]+$"))
            {
                Console.WriteLine("Enter a VALID name");
                yourname = Console.ReadLine();
            }

            Console.WriteLine("Nice to Meet you {0} My name is C#, How old are you?", yourname);
            int age;
            while (!int.TryParse(Console.ReadLine(), out age)) { Console.WriteLine("Enter a Number"); }  ;

            Console.WriteLine("{0} good, as for me I was born in 1992 which make me {1} years old.", age, DateTime.Now.Year - 1992);
        }
    }
}
