using System;
namespace August6thExamples
{
    public class Circle : IShape
    {
        public NumberOfSides NumberOfSides { get ; set; }

        public Circle(NumberOfSides numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
    }
}
