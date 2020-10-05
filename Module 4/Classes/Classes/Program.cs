using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person perOne = new Person();
            perOne.FirstName = "Mark";
            perOne.LastName = "OReilly";
            perOne.Country = "Northern Ireland";
            Person perTwo = new Person();
            perTwo.FirstName = "Janet";
            perTwo.LastName = "Joplin";
            perTwo.Country = "Ireland";
            
            Person perThree = new Person();
            perThree.FirstName = "Daniel";

            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(perTwo.FirstName);
            Console.WriteLine(perThree.FirstName);
        }
    }
    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
           
        }
        public DateTime BirthDate { get; set; }

        public string Country { get; set; }

        public Person()
        {
            FirstName = "Unknown";
        }
    }
}
