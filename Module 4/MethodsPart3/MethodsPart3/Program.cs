using System;
using System.Net;

namespace MethodsPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstEmployee, secondEmployee;
            //firstEmployee = "David Smith";
            //secondEmployee = "Sophia Watson";
            //Console.WriteLine($"inside main method \n--------\n{firstEmployee}\n{secondEmployee}\n\n");
            ChangeNames(out firstEmployee, out secondEmployee);
            Console.WriteLine($"inside main method \n--------\n{firstEmployee}\n{secondEmployee}\n\n");
        }

        static void ChangeNames(out string firstEmp, out string secondEmp)
        {
            firstEmp = "Olivia Aaron";
            secondEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside main method \n--------\n{firstEmp}\n{secondEmp}\n\n");


        }
    }
}
