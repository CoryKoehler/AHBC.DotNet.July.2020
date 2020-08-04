using System;
using System.Collections.Generic;
using System.Text;

namespace August3rdExamples
{
    public class Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }
        
        public virtual double CalculateArea()
        {
            return Length * Height;
        }


        //TODO TALK ABOUT THIS WEDNESDAY
        //public Shape(double length, double height)
        //{
        //    Length = length;
        //    Height = height;
        //}
    }
}
