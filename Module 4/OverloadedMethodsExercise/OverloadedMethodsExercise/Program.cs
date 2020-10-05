using System;
using System.Data;

namespace OverloadedMethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, intResult;
            double x, y, z,doubleResult;

            intResult = 0;
            a = 1;
            b = 2;
            c = 3;
            x = 1.5;
            y = 2.5;
            z = 3.0;

            Console.WriteLine(PerformAdd(a, b));
            Console.WriteLine(PerformAdd(x, y));
        }
        static int PerformAdd(int num1,int num2)
        {

            return num1 + num2;
        }
        static int PerformAdd(int num1, int num2, int num3)
        {

            return num1 + num2 + num3;
        }
        static double PerformAdd(double num1, double num2)
        {

            return num1 + num2;
        }

        static double PerformAdd(double num1, double num2, double num3)
        {

            return num1 + num2+num3;
        }
    }
}
