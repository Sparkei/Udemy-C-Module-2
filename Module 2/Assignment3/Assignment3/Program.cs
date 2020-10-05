using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = DateTime.Now.DayOfWeek.ToString();
            switch (day)
            { case"Saturday":Console.WriteLine("Yellow");break;
               case "Sunday":Console.WriteLine("Green"); break;
                case "Monday":Console.WriteLine("Blue"); break;
                case "Tuesady":Console.WriteLine("Grey"); break;
                case "Wednesday":Console.WriteLine("Red"); break;
                case "Thursday":Console.WriteLine("Orange"); break;
                case "Friday":Console.WriteLine("White"); break;





            }
        }
    }
}
