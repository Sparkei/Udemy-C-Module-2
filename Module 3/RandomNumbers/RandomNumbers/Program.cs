using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = 0;

            x = rand.Next(1,7);
            Console.WriteLine(x);

            double y= 0;
            y = rand.NextDouble()*3;
            Console.WriteLine($"Random Double no is {Math.Round(y)}");

        }
    }
}
