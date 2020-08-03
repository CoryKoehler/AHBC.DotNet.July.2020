using System;
namespace July29ThExamples
{
    public abstract class Automobile
    {
        protected abstract string Model { get; set; }

        public abstract string Make { get; set; }

        public abstract void Build();

        public void Destroy()
        {
            Console.WriteLine("you automible has been destroyed");
        }
    }
}
