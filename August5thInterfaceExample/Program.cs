using System;

namespace August5thInterfaceExample
{
    public class Program
    {
        public static void Main()
        {
            Circle circle = new Circle(100);
            Triangle triangle = new Triangle(3, 4, 5);
            RegularHexagon hexagon = new RegularHexagon(1);

            Console.WriteLine($"Area of circle: {circle.CalculateArea()}");
            Console.WriteLine($"Area of triangle: {triangle.CalculateArea()}");
            Console.WriteLine($"Area of {nameof(RegularHexagon)}: {hexagon.CalculateArea()} and {hexagon.NumberOfSidesAsMessage()}");
        }
    }
}
