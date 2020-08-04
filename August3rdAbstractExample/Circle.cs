using System;
using System.Collections.Generic;
using System.Text;

namespace August3rdAbstractExample
{
    public class Circle : Shape
    {
        public override double CalculateArea()
        {
            //Area = (pi)r^2
            return Math.PI * Math.Pow(Radius, 2);
        }
        public Circle(double radius)
        {
            Radius = radius;
            Radius = 123;
        }

        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new Exception("Circles cannot have a radius of 0");
                }
            }
        }

        public override double Length { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
