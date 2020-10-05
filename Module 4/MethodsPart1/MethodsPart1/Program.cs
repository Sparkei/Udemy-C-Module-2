using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace MethodsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;
            a = 5;
            b = 3;
            addResult = AddOperation(a, b);
            Console.WriteLine($"{a}+{b}={addResult}");
            

            c = 15;
            d = 10;
            addResult = AddOperation(c, d);
            Console.WriteLine($"{c}+{d}={addResult}");

        }

        static int AddOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            return addResult;
        }
        static void DisplayMessage()
        {

            Console.WriteLine("Process is done");
            Console.WriteLine("Process is done by mark");
            Console.WriteLine("Finish time:" +DateTime.Now.ToShortTimeString());
        }
    }
}
