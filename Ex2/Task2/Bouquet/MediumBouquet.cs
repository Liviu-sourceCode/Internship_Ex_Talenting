using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MediumBouquet : Bouquet
    {
        public MediumBouquet()
        {
            Name = "Medium Bouquet";
            AssemblyCost = 2;
            FlowerRequirements = new Dictionary<string, int>
            {
                { "Rose", 6 },
                { "Gladiolus", 5 }
            };
        }
    }
}
