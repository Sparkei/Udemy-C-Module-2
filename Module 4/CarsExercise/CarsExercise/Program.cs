using System;
using System.Xml.Schema;

namespace CarsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Skoda sko = new Skoda();
            sko.DisplayInfo();
        }
    }
    class cars
    { 
    private decimal price;
   
    protected int maxSpeed;
    public string color;
        protected decimal Price
        { 
             get { return price; }
            set { price = value;}
        }
        
        public virtual void DisplayInfo()
        {
          price=1000;
          maxSpeed = 300;
          color = "white";
            Console.WriteLine($"Price is {price}, max speed is {maxSpeed}, color is {color}");

        }
    }
    class Skoda : cars
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            base.color = "Red";
            base.maxSpeed = 100;
            base.Price = 15000;
            Console.WriteLine($"Price is {Price}, max speed is {maxSpeed}, color is {color}");

        }
    }
}
