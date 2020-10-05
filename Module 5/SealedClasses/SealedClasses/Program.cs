using System;

namespace SealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dogs dog = new Dogs();

        }
    }
    sealed class Animal
    {
        string name;
    }

    class Dogs:Animal
    {
        public string dogBread;
    }
}
