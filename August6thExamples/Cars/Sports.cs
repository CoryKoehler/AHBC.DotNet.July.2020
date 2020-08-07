using System;
using August6thExamples.Enums;

namespace August6thExamples.Cars
{
    public class Sports : IAutomobile
    {
        public int Mileage { get; set; }
        public CarType Type { get; set; }

        public void VroomVroom()
        {
            Console.WriteLine("I go vroom vroom fast");
        }
    }
}
