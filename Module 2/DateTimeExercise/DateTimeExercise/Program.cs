using System;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string sDate = "30/09/2017 09:09:59";
            string formatdate = "";
            DateTime mydatetime = DateTime.ParseExact(sDate, "dd/mm/yyyy HH:mm:ss", null);

            Console.WriteLine("Day " + mydatetime.DayOfWeek + Environment.NewLine + "Month " + mydatetime.ToString("MMMM") + Environment.NewLine + "Month " + mydatetime.Year);
            formatdate = string.Format("{0:dd-MM-yyyy HH:mm:ss}", mydatetime);
            Console.WriteLine(formatdate);
            formatdate = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", mydatetime);
            Console.WriteLine(formatdate);
            formatdate = string.Format("{0:'Day' dddd\n'month' MMMM\n'year' yyyy}", mydatetime);
            Console.WriteLine(formatdate);
            Console.ReadKey();


        }
    }
}
