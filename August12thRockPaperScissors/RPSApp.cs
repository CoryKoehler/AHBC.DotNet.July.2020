using System;
using System.Collections.Generic;
using System.Text;

namespace August12thRockPaperScissors
{
    class RPSApp
    {
        public HumanPlayer HumanPlayer;
        public IPlayer Oppponent;

        public void CreatePlayer(string name)
        {
             HumanPlayer = new HumanPlayer(name);
        }

        public void CreateOpponent(int opponentChoice)
        {
            if(opponentChoice == 1)
            {
                Oppponent = new RockPlayer();
            }
            else
            {
                Oppponent = new RandomPlayer();
                Oppponent.Name = "George";
            }
        }
    }
}
