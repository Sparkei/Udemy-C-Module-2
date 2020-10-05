using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekDayName = WeekDay.Friday.ToString();
            WeekDay day = WeekDay.Friday;
            Console.WriteLine((int) day);
        }
    }
    enum WeekDay
    {
        Monday,Tueday,Wednesday,Thursday,Friday=40,Saturday=23,Sunday

    }
}
