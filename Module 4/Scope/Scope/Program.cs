using System;

namespace Scope
{
    class Program
    {
        static string name = "Daniel";
        static void Main(string[] args)
        {
            sayHi();
        }

        static void sayHi() 
        {
            name = "John";
            Console.WriteLine($"Hi {name}");
        }
    }
}
