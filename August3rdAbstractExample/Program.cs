using System;

namespace August3rdAbstractExample
{
    public class Program
    {
        public static void Main()
        {
            Circle circle = new Circle(100);
            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine($"Area of circle: {circle.CalculateArea()}");
            Console.WriteLine($"Area of triangle: {triangle.CalculateArea()}");
        }
    }
}
