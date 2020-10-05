using System;

namespace MathPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            int y = 4;
            //max
            Console.WriteLine("Max is " +Math.Max(x,y));
            //min
            Console.WriteLine("Min is  " + Math.Min(x, y));
            //sqrt
            Console.WriteLine("Sqrt: " + Math.Sqrt(y));
            //pow
            Console.WriteLine("Sqrt: " + Math.Pow(y,2));
            //PI
            Console.WriteLine(Math.PI);
        }
    }
}
