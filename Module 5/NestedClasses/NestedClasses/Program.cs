using System;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            Animals.Dogs dog = new Animals.Dogs();
            Animals.Cats cats =new Animals.Cats();
        }
    }
    class Animals
    {
        public string animalName;
        public string animalCountry;

        public class Dogs
        {
            public string dogBreed;
            public string dogNickname;
        }
        public class Cats
        {
            public string catName
        }
    }
}
