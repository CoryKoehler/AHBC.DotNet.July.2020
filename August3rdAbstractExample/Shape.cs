using System;
using System.Collections.Generic;
using System.Text;

namespace August3rdAbstractExample
{
    public abstract class Shape
    {
        public abstract double Length { get; set; }
        public abstract double Height { get; set; }

        public abstract double CalculateArea();

        //TODO TALK ABOUT THIS WEDNESDAY
        //public Shape(double length, double height)
        //{
        //    Length = length;
        //    Height = height;
        //}
    }
}
