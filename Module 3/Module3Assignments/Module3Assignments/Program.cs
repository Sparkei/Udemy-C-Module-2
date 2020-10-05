using System;

namespace Module3Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Assessment number 4 5 or 6");
            int assignment = int.Parse(Console.ReadLine());

            if (assignment == 4)
            {
                //Assignement 4 
                Console.WriteLine("Assignment 4");
                for (int zeroCount = 16; zeroCount >= 1; zeroCount--)
                {
                    for (int i = 0; i < zeroCount; i++)
                    {
                        Console.Write("0");
                    }
                    Console.WriteLine();
                    //if(zeroCount != 1) Console.WriteLine();

                }
            }
            else
                if (assignment == 5)
            {
                //Assignement 5 
                Console.WriteLine("Assignment 5");
                string[] months ={ "January", "February","March",
                    "April", "May", "June", "July", "August", "Sepember", "October", "November", "December"};
                string[] days = { "31", "28/29", "31", "30", "31", "30", "31", "31", "31", "30", "31", "30", "31" };
                Random rand = new Random();
                int x = rand.Next(0, 12);
                Console.WriteLine($"{months[x]} - {days[x]} days");
            }

            else if (assignment == 6)
            {
                //Assignement 5 
                Console.WriteLine("Assignment 6");
                string response = "";
                Random dice = new Random();
                do
                { Console.WriteLine("Roll Dice? (yes,no)");
                    response = Console.ReadLine().Trim().ToUpper();
                    if (response == "YES"){
                        Console.WriteLine("New Dice Number is " + dice.Next(1, 7));
                    }
                }
                while (response != "NO");

            }
            else { Console.WriteLine("Invalid input"); }
        }
    }
}
