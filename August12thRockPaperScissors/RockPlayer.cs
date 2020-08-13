using System;
using System.Collections.Generic;
using System.Text;

namespace August12thRockPaperScissors
{
    public class RockPlayer : IPlayer
    {
        public string Name { get; set; }
        public RockPlayer()
        {
            Name = "The Rock";
        }

        public RPS GenerateRPS(RPS userChoice = RPS.paper)
        {
            return RPS.rock;
        }
    }
}
