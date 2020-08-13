using System;

namespace August12thRockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!!!!");
            Console.WriteLine("What is your name? :");
            var userName = Console.ReadLine();
            var rpsApp = new RPSApp();
            rpsApp.CreatePlayer(userName);
            Console.WriteLine($"Almost ready to Rumble {rpsApp.HumanPlayer.Name}!");

            Console.WriteLine("Please choose your opponent: 1. RockPlayer or 2. RandomPlayer");
            var opponentChoice = int.Parse(Console.ReadLine());
            rpsApp.CreateOpponent(opponentChoice);

            Console.WriteLine($"{rpsApp.HumanPlayer.Name} make a selection 1. Rock or 2. Paper, or 3. Scissors !!!");
            var playerRPS = (RPS) int.Parse(Console.ReadLine());
            //rpsApp.HumanPlayer.GenerateRPS(playerRPS);
            var opponentRPS = rpsApp.Oppponent.GenerateRPS();
            Console.WriteLine($"{rpsApp.Oppponent.Name} selected {opponentRPS}");

            switch (playerRPS)
            {
                case RPS.rock:
                    if (opponentRPS == RPS.rock)
                        Console.WriteLine("You tied!");
                    else if (opponentRPS == RPS.paper)
                        Console.WriteLine("You lost!");
                    else if (opponentRPS == RPS.scissors)
                        Console.WriteLine("You won!");
                    break;
                case RPS.paper:
                    if (opponentRPS == RPS.rock)
                        Console.WriteLine("You won!");
                    else if (opponentRPS == RPS.paper)
                        Console.WriteLine("You tied!");
                    else if (opponentRPS == RPS.scissors)
                        Console.WriteLine("You lost!");
                    break;
                case RPS.scissors:
                    if (opponentRPS == RPS.rock)
                        Console.WriteLine("You lost!");
                    else if (opponentRPS == RPS.paper)
                        Console.WriteLine("You won!");
                    else if (opponentRPS == RPS.scissors)
                        Console.WriteLine("You tied!");
                    break;
            }

            Console.WriteLine("Do you want to play again? (y:n)");

        }
    }
}
