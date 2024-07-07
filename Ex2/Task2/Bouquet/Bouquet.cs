using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Bouquet
    {
        public string Name { get; protected set; }
        public int AssemblyCost { get; protected set; }
        public Dictionary<string, int> FlowerRequirements { get; protected set; }

        // Metoda pentru calcularea pretului buchetului
        public int CalculatePrice(Dictionary<string, int> flowerPrices)
        {
            int totalFlowerCost = 0;
            foreach (var flower in FlowerRequirements)
            {
                totalFlowerCost += flowerPrices[flower.Key] * flower.Value;
            }
            return totalFlowerCost + AssemblyCost;
        }
    }
}
