using System;
using System.Collections;

namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //create
            Hashtable companies = new Hashtable();

            companies.Add("Microsoft", "USA");
            companies.Add("Sony", "Japan");
            companies.Add("IKEA", "Sweeden");
            companies.Add("Tayto", "Ireland");
            companies.Add("BMW", "Germany");

            //display 
            foreach (DictionaryEntry item in companies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            //Capacity 
            Console.WriteLine($"Count is {companies.Count} \n");

            //Remove 
            Console.WriteLine("After Removing");
            companies.Remove("IKEA");
            foreach (DictionaryEntry item in companies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            //Contains
            Console.WriteLine("\nContains");
            if (companies.Contains("Sony"))
            {
                Console.WriteLine("Yes contains sony");
            }
            else
            {
                Console.WriteLine("Nope no sony");
            }

            Console.WriteLine("\nAfter Copying");
            //Copy to arraylist
            ArrayList companyArray = new ArrayList(companies.Values);
            foreach (var item in companyArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
