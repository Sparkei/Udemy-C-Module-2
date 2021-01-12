using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputArrayLoop(0, 1, 2, 3, 4, 5);
            OutputArrayLoop("f", "i", "f", "a");

        }

        private static void OutputArrayLoop<T>(params T[] inputvalues)
        {
            foreach (var item in inputvalues)
            {
                Console.WriteLine(item);
            }
        }
    }
}
