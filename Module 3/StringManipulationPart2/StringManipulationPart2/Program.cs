using System;

namespace StringManipulationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "Game of Thrones";
            //index of
            Console.WriteLine(tvShow.IndexOf('o'));
            //last index of
            Console.WriteLine(tvShow.LastIndexOf('o'));
            //substring
            Console.WriteLine(tvShow.Substring(4));
            //Remove
            Console.WriteLine(tvShow.Remove(4));

            //Insert
            Console.WriteLine(tvShow.Insert(0,"The "));

            var bit = new bool[] { true, false };
        }
    }
}
