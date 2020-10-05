using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            dogs dog = new dogs();
            Birds bird = new Birds();
         
        }
        class Animal
        {
            public string animalName;
            public DateTime animalBirthDate;

            public void feedAnimal()
            {

            }
        }
        class dogs:Animal
        {
            public string dogBreed;
            public string dogIntelligence;
            public bool isEasyToTrain;

        }

        class Birds : Animal
        {
            public string birdColour;
            public string birdCountry;
        

        }

    }
}
