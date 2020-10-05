using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int.TryParse(Console.ReadLine(),out int x);
            if (x == 0)
            {
                Console.WriteLine("Invalid input");

            }
            else { 
            Console.WriteLine("You have enetered number " + x);
            }
        }
    }
}
