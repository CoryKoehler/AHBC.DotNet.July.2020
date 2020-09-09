using System;

namespace September9thMockAssement3
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = new Town();
            var isAlive = town.SurviveTheWinter();
            Console.WriteLine(isAlive);
        }
    }
}
