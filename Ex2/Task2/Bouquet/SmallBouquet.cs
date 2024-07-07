using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SmallBouquet : Bouquet
    {
        public SmallBouquet()
        {
            Name = "Small Bouquet";
            AssemblyCost = 2;
            FlowerRequirements = new Dictionary<string, int>
            {
                { "Rose", 5 }
            };
        }
    }
}
