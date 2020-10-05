using System;

namespace StringManiuplationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "Game of Thrones     ";
            string seasonOne = " - Season 1";
            string newname = "";

            newname = tvShow.Insert(tvShow.Trim().Length, seasonOne);
            Console.WriteLine(newname);
        } 
    }
}
