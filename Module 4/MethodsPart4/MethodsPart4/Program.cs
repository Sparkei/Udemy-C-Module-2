using System;

namespace MethodsPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            string guestName = "";

            Console.WriteLine("Hello Guest what is your name");
            guestName = Console.ReadLine();

            if (guestName == string.Empty)
            {
                WelcomeGuest();
            }
            else { WelcomeGuest(guestName);
            }
        }
        static void WelcomeGuest() {
            Console.WriteLine("OK, Hope u enjoy stay");
        
        }

        static void WelcomeGuest(string name) {
            Console.WriteLine($"Hi {name}, Hope u enjoy stay");

        }
    }
}
