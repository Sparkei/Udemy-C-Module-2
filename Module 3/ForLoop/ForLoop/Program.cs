using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=10;i>1;i--) {
                if (i == 2) break;
                Console.WriteLine($"The value of variable i is {i}");
            }
        }
    }
}
