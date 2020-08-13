using System;
using System.Collections.Generic;
using System.Text;

namespace August12thRockPaperScissors
{
    public class RandomPlayer : IPlayer
    {
        public string Name { get; set; }

        public RPS GenerateRPS(RPS userChoice = RPS.paper)
        {
            Random random = new Random();
            return (RPS)random.Next(3);
        }
    }
}
