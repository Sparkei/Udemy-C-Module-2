using System;

namespace Simple_Mehtod_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GetName();
        }

        static void GetName()
        {
            Console.WriteLine("What is your Name?");
            string response = Console.ReadLine();
            SayHi(response);

        }

        static void SayHi(string name)
        {
            Console.WriteLine($"Welcome {name} I hope you are well");

        }
    }
}
