using System;
using MyOwnNameSpace.GameOfThrones;


namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOwnNameSpace.Animal animal= new MyOwnNameSpace.Animal();
            animal.sayHi();
            //MyOwnNameSpace.GameOfThrones.HouseStark.sayQuote();
            HouseStark.sayQuote();
        }
    }
}
namespace MyOwnNameSpace
{
    class Animal
    {
        public string animalColor;

        public void sayHi()
        {
            Console.WriteLine("HI");
        }

    }
    class Trainers
    {

    }
    namespace GameOfThrones
    {
        class HouseStark
        {
            public static void sayQuote()
            {
                Console.WriteLine("The norse Remembers");
            }
        }

    }

}