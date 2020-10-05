using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Arithmatic_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.Parse("5")+ int.Parse("2"));
            Console.WriteLine(int.Parse("5") - int.Parse("2"));
            Console.WriteLine(int.Parse("5") * int.Parse("2"));
            Console.WriteLine(int.Parse("5") / int.Parse("2"));
            Console.WriteLine(int.Parse("5") % int.Parse("2"));
            int a,b, addResult, subtractResult, multiplyResult, remainderResult;
            float divideReuslt;
            Console.WriteLine("Enter Number 1");
            a = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Enter Number 2");
            b= int.Parse(Console.ReadLine());

            addResult = a + b;
            Console.WriteLine(a + " + " + b + " = " + addResult);
            subtractResult = a - b;
            Console.WriteLine(a + " - " + b + " = " + subtractResult);
            multiplyResult = a * b;
            Console.WriteLine(a + " * " + b + " = " + multiplyResult);

            divideReuslt = (float) a / (float)b;
            Console.WriteLine(a + " * " + b + " = " + divideReuslt);

            remainderResult = a % b;
            Console.WriteLine(a + "%" + b + " = " + remainderResult);
        }
    }
}
