using System;
using System.IO;

namespace Assignment_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = string.Empty;
            path = @"\\penn-data\edt$\EDT Letters";
            DisplayFolder(path, 0);
        }

        private static void DisplayFolder(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
                DisplayFolder(folder, indent + 1);
            }
        }
    }
}
