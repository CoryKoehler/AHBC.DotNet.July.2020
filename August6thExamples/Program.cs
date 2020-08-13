using System;
using System.Linq;
using System.Net.Security;
using August6thExamples.Cars;
using August6thExamples.Enums;

namespace August6thExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInputForShapes();
            UserInputForAutomobiles();

            //HOW TO GET a list of a enum
            //var listofCarType = Enum.GetValues(typeof(CarType)).Cast<CarType>().ToList();
        }

        private static void UserInputForAutomobiles()
        {
            Console.WriteLine("What is your dream car?");
            var UserInput = Console.ReadLine();
            var isCarType = Enum.TryParse(UserInput, out CarType carType);
            if (isCarType)
            {
                IAutomobile automobile;

                switch (carType)
                {
                    case CarType.Suv:
                        automobile = new SUV();
                        automobile.Mileage = 170;
                        automobile.Type = carType;
                        automobile.VroomVroom();
                        break;

                    case CarType.Rickshaw:
                        automobile = new Rickshaw
                        {
                            Mileage = 5,
                            Type = carType
                        };
                        automobile.VroomVroom();
                        break;
                    case CarType.Sports:
                        automobile = new Sports();
                        automobile.Mileage = 75;
                        automobile.Type = carType;
                        automobile.VroomVroom();
                        break;
                }
            }
        }

        private static void UserInputForShapes()
        {
            Console.WriteLine("What shape would you like to use ?");
            Console.WriteLine("Enter the side of the shape");

            var userInput = Console.ReadLine();

            var didParse = Enum.TryParse(userInput, out NumberOfSides side);
            var hexagonName = (NumberOfSides)6;
            Console.WriteLine($"{hexagonName}");

            IShape shape;
            switch (side)
            {
                case NumberOfSides.Circle:
                    Console.WriteLine("You entered a Circle");
                    shape = new Circle(side);
                    shape.NumberOfSides = side;
                    break;

                case NumberOfSides.Triangle:
                    Console.WriteLine("You entered a Triangle");
                    shape = new Triangle();
                    shape.NumberOfSides = side;
                    break;

                case NumberOfSides.Rectangle:
                    Console.WriteLine("You entered a Rectangle");
                    shape = new Rectangle();
                    shape.NumberOfSides = side;
                    break;

                case NumberOfSides.Hexagon:
                    shape = new Hexagon();
                    shape.NumberOfSides = side;
                    Console.WriteLine($"You entered a Hexagon {(int)shape.NumberOfSides}");
                    break;
                default:
                    break;
            }
        }
    }
}
