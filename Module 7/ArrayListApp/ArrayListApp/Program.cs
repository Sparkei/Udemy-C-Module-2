using System;
using System.Collections;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            //Adding 
            array.Add("Mark");
            array.Add("Jess");
            array.Add("Ahmad");
            array.Add("Steven");
            Console.WriteLine(array.Count);
            Console.WriteLine(PrintArray(array));
            Console.WriteLine("Sort");
            array.Sort();
            Console.WriteLine(PrintArray(array));
            Console.WriteLine("Reverse");
            array.Reverse();
            Console.WriteLine(PrintArray(array));
            Console.WriteLine("Remove");
            array.Remove("Ahmad");
            // array.RemoveAt(2);
            //array.RemoveAll;
            //arrau.RemoveRange(1,3)
            Console.WriteLine(PrintArray(array));
            Console.WriteLine("Contains ");
            Console.WriteLine(array.Contains("Mark"));

            //get range. 
            ArrayList names = new ArrayList();
            names = array.GetRange(0.2);
            Console.WriteLine(PrintArray(names));

        }

        private static string PrintArray(ArrayList array)
        {
            string arrayContents = default;
            foreach (var item in array)
            {
                arrayContents += item + "\n";
            }
            arrayContents += "--------";
            return arrayContents;
        }
    }
}
