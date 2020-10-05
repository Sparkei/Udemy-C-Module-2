using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClasses
{
    partial class Animals
    {
        public string animalColor;
        public string animalName;

        public void GetName()
        {
            Console.WriteLine("My name is Max, I am a dog WOOF!");
        }
    }
}
