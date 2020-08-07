using System;
using August6thExamples.Enums;

namespace August6thExamples.Cars
{
    public interface IAutomobile
    {
        public int Mileage { get; set; }
        public CarType Type { get; set; }
        public void VroomVroom();
    }
}
