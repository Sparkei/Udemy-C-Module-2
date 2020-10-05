using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 10, 100, 10000, 100000 };
            //string[] weekdays = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            /*
            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine(weekdays[i]);
            }*/

          
            //for each does same as for loop and easier 
            foreach (var name in weekdays)
            {
                Console.WriteLine(name);

            }
        }
    }
}
