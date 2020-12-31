using System;
using System.Collections.Generic;

namespace TuplesExercie
{
    class Program
    {
        static void Main(string[] args)
        {

            var employInfo = new List<Tuple<int, string, string, DateTime>>();
            employInfo.Add(new Tuple<int, string, string, DateTime>(3, "Mark", "OReilly", new DateTime(2016, 05, 01)));
            employInfo.Add(Tuple.Create(1, "Tom", "Barnes", new DateTime(2020, 04, 04)));
            Console.WriteLine("Before Sorting");
            foreach (var employee in employInfo)
            {
                Console.WriteLine($"{employee.Item1}, {employee.Item2}, {employee.Item3}");
            }

            Console.WriteLine("After Sorting");
            employInfo.Sort();
            foreach (var employee in employInfo)
            {
                Console.WriteLine($"{employee.Item1}, {employee.Item2}, {employee.Item3}");
            }

        }
    }
}
