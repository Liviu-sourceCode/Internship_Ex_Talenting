using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class FlowerShop
    {
        private Dictionary<string, int> flowerPrices;

        public FlowerShop()
        {
            flowerPrices = new Dictionary<string, int>
            {
                { "Rose", 10 },
                { "Gladiolus", 15 },
                { "Hydrangea", 30 }
            };
        }

        // Metoda pentru vanzarea unui tip de buchet
        private int SellBouquetType(int quantity, Bouquet bouquet)
        {
            int pricePerBouquet = bouquet.CalculatePrice(flowerPrices);
            return quantity * pricePerBouquet;  // Returnam venitul total generat din vanzarea buchetelor
        }

        public void SellBouquets(int bigBouquets, int mediumBouquets, int smallBouquets)
        {
            int numberOfDays = 30;

            int totalBigBouquets = bigBouquets * numberOfDays;
            int totalMediumBouquets = mediumBouquets * numberOfDays;
            int totalSmallBouquets = smallBouquets * numberOfDays;

            // Calculam venitul total din vanzarea buchetelor
            int incomeBigBouquets = SellBouquetType(totalBigBouquets, new BigBouquet());
            int incomeMediumBouquets = SellBouquetType(totalMediumBouquets, new MediumBouquet());
            int incomeSmallBouquets = SellBouquetType(totalSmallBouquets, new SmallBouquet());

            // Afisare cantitati si profit pentru buchete
            Console.WriteLine($"Buchete mari vandute: {totalBigBouquets}, Profit: {incomeBigBouquets} RON");
            Console.WriteLine($"Buchete medii vandute: {totalMediumBouquets}, Profit: {incomeMediumBouquets} RON");
            Console.WriteLine($"Buchete mici vandute: {totalSmallBouquets}, Profit: {incomeSmallBouquets} RON");

            int totalIncome = incomeBigBouquets + incomeMediumBouquets + incomeSmallBouquets;
            Console.WriteLine($"Venitul total din vanzarea buchetelor: {totalIncome} RON");
        }

        // Metoda pentru vanzarea unui tip de floare
        private int SellFlower(string flowerType, int quantity)
        {
            return quantity; // Returnam cantitatea vanduta pentru floarea respectiva
        }

        public void SellIndividualFlowers(int roses, int gladiolus, int hydrangeas)
        {
            int numberOfDays = 30;

            int totalRoses = roses * numberOfDays;
            int totalGladiolus = gladiolus * numberOfDays;
            int totalHydrangeas = hydrangeas * numberOfDays;

            // Cantitati vandute si profit pentru fiecare tip de floare individuala
            int soldRoses = SellFlower("Rose", totalRoses);
            int soldGladiolus = SellFlower("Gladiolus", totalGladiolus);
            int soldHydrangeas = SellFlower("Hydrangea", totalHydrangeas);

            // Afisare cantitati si profit pentru flori individuale
            Console.WriteLine($"Trandafiri vanduti: {soldRoses}, Profit: {soldRoses * flowerPrices["Rose"]} RON");
            Console.WriteLine($"Gladiole vandute: {soldGladiolus}, Profit: {soldGladiolus * flowerPrices["Gladiolus"]} RON");
            Console.WriteLine($"Hortensii vandute: {soldHydrangeas}, Profit: {soldHydrangeas * flowerPrices["Hydrangea"]} RON");

            int totalIncome = soldRoses * flowerPrices["Rose"] + soldGladiolus * flowerPrices["Gladiolus"] + soldHydrangeas * flowerPrices["Hydrangea"];
            Console.WriteLine($"Venitul total din vanzarea florilor individuale: {totalIncome} RON");
        }

        
    }
}
