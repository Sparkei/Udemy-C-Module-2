using System;

namespace String_Interoplation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("What is your Name");
            name=Console.ReadLine();

            //Console.WriteLine("Welcome back "+ name);
            //Console.WriteLine("Welcome back {0}", name);
            Console.WriteLine($"Welcome back {name}");
        }
    }
}
