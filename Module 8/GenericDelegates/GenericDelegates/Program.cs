using System;

namespace GenericDelegates
{
    class Program
    {
        public delegate T DisplayInfo<T>(T value);
        static void Main(string[] args)
        {
            DisplayInfo<int> myNumber = new DisplayInfo<int>(DisplayValue);
            Console.WriteLine(myNumber(10));
            DisplayInfo<double> myDoubleNumber = new DisplayInfo<double>(DisplayValue);
            Console.WriteLine(myDoubleNumber(6.5));
        }

        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine($"Accessing variable of type {value.GetType().Name}");
            return value;
        }
    }
}
