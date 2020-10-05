using System;
using System.Runtime.CompilerServices;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x<=10)
            {
                Console.WriteLine($"This is line number {x}");
                x++;

            }
            int y= 10;
            while (y >= 1)
            {
                Console.WriteLine($"Malcom in the Middle Season {y}");
                y--;
                if (y == 3) break;
            }
            Console.WriteLine("Do While Loop");
            do
            {
                Console.WriteLine($"this is linenumber {y} ");
                y++;
            } while (y<=10);
                
                    

        }
    }
}
