using System;
using System.Collections.Generic;
using System.Text;

namespace August5thInterfaceExample
{
    public class RegularHexagon : IShape
    {
        public int NumberOfSides { get; set; }

        private double _sideLength;
        public double SideLength 
        { 
            get
            { 
                return _sideLength;
            }
            set 
            { 
                if (value > 0)
                {
                    _sideLength = value;
                }
                else
                {
                    throw new Exception("Side Length cannot be 0 or less!!!");
                }
            } 
        }

        public RegularHexagon(double sideLength)
        {
            SideLength = sideLength;
            NumberOfSides = 6;
        }

        public double CalculateArea()
        {
            var area = (3 * Math.Sqrt(3) * Math.Pow(SideLength, 2) / 2);

            return area;
        }

        public string NumberOfSidesAsMessage()
        {
            return $"A {nameof(RegularHexagon)} has {NumberOfSides} sides";
        }
    }
}
