using System;
using System.Collections.Generic;
using System.Linq;

namespace August12thExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int AddStarWarsCharacters(string[] starWarsCharactersArray)
        {
            //findIndex returns -1 if not found already
            return Array.FindIndex(starWarsCharactersArray,
                entry => string.Equals(entry, "Yoda", StringComparison.InvariantCultureIgnoreCase));
        }

        static string DeathStarCombat(Dictionary<string, int> starWarsCharacters)
        {
            var highestCombatCharacter = starWarsCharacters.OrderByDescending(entry => entry.Value).First().Key;
            return highestCombatCharacter;
        }

        static List<string> ConvertPlanets(string[] planetArray)
        {
            return planetArray.Reverse().ToList();
        }

        static double AverageDroids(List<int> droids)
        {
            var evenDroids = new List<int>();
            foreach(var droid in droids)
            {
                if(droid % 2 == 0)
                {
                    evenDroids.Add(droid);
                }
            }

            return evenDroids.Average();
        }

        static string TryToCatchDarthVader(string caught)
        {
            var success = int.TryParse(caught, out int result);
            if(success)
            {
                return "Vader was captured";
            }
            else
            {
                return "Vader Got Away";
            }
        }

        static string TryToCatchVaderWithTryCatch(string caught)
        {
            try
            {
                int.Parse(caught);
                return "Vader was captured";
            }
            catch (Exception)
            {
                return "Vader got away";
            }
        }
    }
}
