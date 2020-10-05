using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Lines line = new Lines();
            line.SayHi(); line.Draw();
        }

        abstract class Shapes
        {
            abstract public void Draw();
            public void SayHi()
            {
                Console.WriteLine("Hello from the abstract Siiide");
            }
        }
        class Lines : Shapes
        {
            public override void Draw()
            {
                Console.WriteLine("Hi i'm a line");
            }
        }
    }
}
