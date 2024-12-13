using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ConsoleApp1
{
    public class Car
    {
          public string Name { get; set; }
          public string Color { get; set; }

        public Car(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            Car myCar1 = new Car("Mercedes Benz", "Purple");
            Car myCar2 = new Car("Audi", "Black");

            myCar2.Color = "White";

            Console.WriteLine(myCar2.Color);
        }
    }
}