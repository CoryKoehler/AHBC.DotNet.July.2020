using System;
using System.Collections.Generic;
using System.Text;

namespace August3rdExamples
{
    public class Triangle : Shape
    {
        public override double CalculateArea()
        {
            var s = (Side1length + Side2length + Side3length) / 2;
            var  area = (int)Math.Round(Math.Sqrt(s*(s-Side1length)*(s-Side2length)*(s-Side3length)),2);
            return area;
        }

        public Triangle(double side1length, double side2length, double side3length)
        {
            Side1length = side1length;
            Side2length = side2length;
            Side3length = side3length;
        }
        public double Side1length { get; set; }
        public double Side2length { get; set; }
        public double Side3length { get; set; }
    }
}
