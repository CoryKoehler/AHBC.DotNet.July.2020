using System;
using System.Collections.Generic;

namespace September9thMockAssement3
{
    public class Town
    {
        public List<Villager> Villagers { get; set; }

        public Town()
        {
            Villagers = new List<Villager>
            {
                new Farmer(),
                new Slacker(),
                new Slacker(),
                new Slacker(),
            };
        }

        public int Harvest()
        {
            int farmTotals = 0;
            foreach (var villager in Villagers)
            {
                farmTotals += villager.Farm();
            }
            return farmTotals;
        }

        public int CalcFoodConsumption()
        {
            int foodConsumption = 0;

            foreach (var villager in Villagers)
            {
                foodConsumption += villager.Hunger;
            }
            return foodConsumption; 
        }

        public bool SurviveTheWinter()
        {
            var totalHarvest = Harvest();
            var totalHunger = CalcFoodConsumption();

            return totalHunger <= totalHarvest;
        }
    }
}
