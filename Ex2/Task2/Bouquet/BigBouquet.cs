using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BigBouquet : Bouquet
    {
        public BigBouquet()
        {
            Name = "Big Bouquet";
            AssemblyCost = 2;
            FlowerRequirements = new Dictionary<string, int>
            {
                { "Rose", 9 },
                { "Gladiolus", 10 },
                { "Hydrangea", 3 }
            };
        }
    }
}
