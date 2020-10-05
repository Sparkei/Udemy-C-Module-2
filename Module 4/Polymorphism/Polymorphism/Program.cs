using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            shapes[] shapes = new shapes[4];
            shapes[0] = new shapes();
            shapes[1] = new Circles();
            shapes[2] = new Lines();
            shapes[3] = new Triangle();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
        class shapes
        {
            public virtual void Draw()
            {
                Console.WriteLine("I am a simple shape");
            }
        }
        class Circles : shapes
        {
            public override void Draw()
            {
                Console.WriteLine("I am a circle");
            }

        }

        class Lines : shapes
        {
            public override void Draw()
            {
                Console.WriteLine("I am a line");
            }

        }
        class Triangle : shapes
        {
            public override void Draw()
            {
                Console.WriteLine("I am a traingle");
            }

        }
    }
}
