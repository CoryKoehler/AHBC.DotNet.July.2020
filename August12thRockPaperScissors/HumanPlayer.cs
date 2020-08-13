using System;
using System.Collections.Generic;
using System.Text;

namespace August12thRockPaperScissors
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public RPS GenerateRPS(RPS userChoice = RPS.paper)
        {
            return userChoice;
        }
    }
}
