using System;
using System.IO;

namespace RecursionFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = string.Empty;
            path = @"C:\Github";
            DisplayFolder(path, 0);
        }

        private static void DisplayFolder(string path, int indent)
        {
            
            foreach (var folder in Directory.GetDirectories(path))
            {
                files(folder, indent); // assignment
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)} {File.GetCreationTime(folder)}");

                DisplayFolder(folder, indent + 1);
            }
        }

        private static void files(string folder, int indent)
        {
            string[] directories = Directory.GetFiles(folder);
            foreach (string directory in directories)
            {
                Console.WriteLine("{0}{1}", new string(' ', indent), directory + " : created on (" + File.GetCreationTime(directory) + ")");
            }

        }
    }
}
