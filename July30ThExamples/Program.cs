using System;

namespace July30ThExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side lengths of the triangle:");
            int side1length = int.Parse(Console.ReadLine());
            int side2length = int.Parse(Console.ReadLine());
            int side3length = int.Parse(Console.ReadLine());

            var triangle1 = new Triangle(side1length, side2length, side3length);

            Console.WriteLine($"The perimeter is {triangle1.Side1Length}, and {triangle1.Side2Length}, and {triangle1.Side3Length}");

        }
    }
}
