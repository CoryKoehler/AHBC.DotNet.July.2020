using System;
using System.Collections.Generic;
using System.Text;

namespace August3rdExamples
{
    public class Square : Shape
    {
        public Square(double length, double height)
        {
            base.Length = length;
            base.Height = height;
        }

        public override double CalculateArea()
        {
            return base.CalculateArea();
            //return base.Length * base.Height;
        }
    }
}
