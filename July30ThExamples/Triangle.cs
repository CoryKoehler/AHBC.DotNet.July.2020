using System;
namespace July30ThExamples
{
    public class Triangle
    {
        private string name;

        public int Side1Length { get; set; }

        public int Side2Length { get; set; }

        public int Side3Length { get; set; }

        public int CalculatePerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }

        public int CalculateArea()
        {
            var semiPerimeter =  CalculatePerimeter() / 2;

            var area = (int)Math.Sqrt(semiPerimeter * (semiPerimeter - Side1Length) * (semiPerimeter - Side2Length) * (semiPerimeter - Side3Length));

            return area;
        }
        public Triangle (int side1length, int side2length, int side3length)
        {
            Side1Length = side1length;
            Side2Length = side2length;
            Side3Length = side3length;
        }
    }
}
