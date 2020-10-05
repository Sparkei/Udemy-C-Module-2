using System;

namespace EvenOrOddExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int remainder;
            Console.WriteLine("Enter an integer");
            input= int.Parse (Console.ReadLine());

            remainder = input % 2;

            if (remainder == 1) 
            {
                Console.WriteLine("Odd");
            }
            else 
            {
                Console.WriteLine("Even");
            };

        }
    }
}
