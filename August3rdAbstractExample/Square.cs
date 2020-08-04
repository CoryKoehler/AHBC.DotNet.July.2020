using System;
using System.Collections.Generic;
using System.Text;

namespace August3rdAbstractExample
{
    public class Square : Shape
    {
        public override double Length { get; set; }
        public override double Height { get; set; }

        public Square(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Length * Height;
        }
    }
}
