using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlowerShop flowerShop = new FlowerShop();

          
            Console.WriteLine("Vanzarile pe luna Noiembrie (30 zile):");
            // (buchet mare, mediu, mic)
            flowerShop.SellBouquets(13, 10, 12);
            // (trandafiri, gladiole, hortensii)
            flowerShop.SellIndividualFlowers(15, 10, 25);
        }
    }
    
}


