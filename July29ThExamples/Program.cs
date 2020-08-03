using System;
using System.Collections.Generic;

namespace July29ThExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var animal = new Animal("Red", "Tiger", "Fred");
            Animal animal = new Animal();
            var dog = new Dog();
            dog.Bark();
            dog.Color = "Blue";
            dog.Name = "Lassie";
            dog.Size = 2;

            var sedan = new Sedan("Ford", "Focus", 3);
            sedan.Build();

            Automobile automobile = new Sedan("Chevy", "Malibu", 4);
            Automobile automobile2 = new Wagon();

            List<Wagon> wagons = new List<Wagon>();

            List<Automobile> automobiles = new List<Automobile>()
            {
                //new Wagon(),
                new Sedan("Chevy", "Cruz", 4),
                new Mustang("Ford", "Focus", 3)
            };

            foreach (var vehicle in automobiles)
            {
                Console.WriteLine(vehicle.Make);
            }

            Console.WriteLine(animal);

            //Excerise 42
            //Console.WriteLine("Enter X point");
            //var xPoint = Console.ReadLine();
            //Console.WriteLine("Enter Y point");
            //var yPoint = Console.ReadLine();

            //var point = new Point(xPoint, yPoint);
            //Console.WriteLine($"Here is the XPoint {point.X}, and YPoint {point.Y}");

            var mustang = new Mustang("Ford", "Focus", 3);
            mustang.Build();
        }
    }
}
