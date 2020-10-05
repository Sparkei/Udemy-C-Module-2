using System;

namespace StringManipulationPart1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string moviename = "    lord of the rings";
            Console.WriteLine(moviename[10]);
            Console.WriteLine(moviename.Trim());
            Console.WriteLine(moviename.Trim().ToUpper());
            Console.WriteLine(moviename.Trim().Replace("l","L"));

        }
    }
}
