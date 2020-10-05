using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                Console.WriteLine($"First Loop i= {i}");
                for (int j=1;j<=4;j++)
                {
                    Console.WriteLine($"Second loop j= {j}");

                }
                Console.WriteLine();
            }
            
        }
    }
}
