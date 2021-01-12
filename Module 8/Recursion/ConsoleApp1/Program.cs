using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            Console.WriteLine(Facotrial(number));
        }

        private static int Facotrial(int number)
        {
            if (number == 0)
                return 1;
            return number * Facotrial(number - 1);
        }
    }
}
