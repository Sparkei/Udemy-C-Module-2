using System;
using System.Linq.Expressions;

namespace ExceptionExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            DoCalculation();

        }

        public static int GetInput()
        {
            string _val = "";
            Console.Write("Enter your value: ");
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }

            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter || _val == "");
            Console.WriteLine("");
            return int.Parse(_val);

        }
        public static void DoCalculation()
        {
            int number1 = GetInput();
            int number2 = GetInput();
            double divResult;

            try
            {
                divResult = (double)number1 / (double)number2;
                Console.WriteLine($"Result = {divResult} \n");
            }
            catch (DivideByZeroException)

            {
                Console.WriteLine($"Cannot divide by secor");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");


            }


        }
    }

    
}
