using System;
using System.Collections.Generic;
using System.Text;

namespace August12thRockPaperScissors
{
    public interface IPlayer
    {
        public string Name { get; set; }

        public RPS GenerateRPS(RPS userChoice = RPS.paper);
    }
}
