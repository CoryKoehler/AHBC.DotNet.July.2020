using System;
namespace July29ThExamples
{
    public class Wagon : Automobile
    {
        public Wagon()
        {
        }

        public override string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Build()
        {
            throw new NotImplementedException();
        }
    }
}
