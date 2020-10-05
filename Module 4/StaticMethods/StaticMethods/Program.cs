using System;
using System.Xml.Serialization;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHi();
        }

        static void SayHi()
        {
            Console.WriteLine("Hi from static method");
        }
    }

    class Person
    {
        public void SayHi()
        {
            Console.WriteLine("High from the non static Method");
        }

    }
}
