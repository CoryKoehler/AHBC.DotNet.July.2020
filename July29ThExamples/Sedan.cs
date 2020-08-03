using System;
namespace July29ThExamples
{
    public class Sedan : Automobile
    {
        public override string Make { get; set; }
        protected override string Model { get; set; }
        public int Tires { get; set; }

        public Sedan(string make, string model, int tires)
        {
            Make = make;
            Model = model;
            Tires = tires;
        }

        public Sedan(string make)
        {
            Make = make;
        }

        public override void Build()
        {
            var numberOFtires = CreateTires();
            Console.WriteLine($"I have built a sedan with :{Make} and {Model} with tires :{Tires}");
        }

        private int CreateTires()
        {
            return Tires + 1;
        }
    }
}
