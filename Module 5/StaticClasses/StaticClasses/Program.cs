using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal.GetAge();
        }
    }
    static class Animal
    {
        public static string name;

        public static void GetAge()
        {
            Console.WriteLine(DateTime.Now.Year - DateTime.Now.AddYears(-2).Year);
        }
    }
}
