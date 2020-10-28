using System;
using System.Collections;

namespace AnimalsandTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal bug = new Animal();
            bug.Name = "Weedle";

            Animal cat = new Animal();
            cat.Name = "Fraser";

            Animal elephant = new Animal();
            elephant.Name = "Stompy";

            Trainer john = new Trainer();
            john.TrainerName = "John Jandy";

            ArrayList animalTrainerList = new ArrayList();
            animalTrainerList.Add(bug);
            animalTrainerList.Add(cat);
            animalTrainerList.Add(elephant);
            animalTrainerList.Add(john);

            foreach (var item in animalTrainerList)
            {
                if (typeof(Animal) == item.GetType())
                {
                    ((Animal)item).SayHi();
                    ((Animal)item).Feed();
                }

                if (typeof(Trainer) == item.GetType())
                {
                    ((Trainer)item).SayHi();
                }
            }
        }
    }
    struct Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine($"Hello my name is {name}");
        }

        public void Feed()
        {
            Console.WriteLine($"{name} is now eating");
        }
    }
    struct Trainer
    {
        private string trinerName;

        public string TrainerName
        {
            get { return trinerName; }
            set { trinerName = value; }
        }
        public void SayHi()
        {
            Console.WriteLine("Hello i'm new trainer");
        }
    }
}
