using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numere extrase:");
            int[] numereLoto = LotoNumere();
            int[] numereJucator = CitesteNumere();


            bool castigator = VerificareCastig(numereJucator, numereLoto);

            if (castigator)
            {
                Console.WriteLine("Felicitari, ai castigat!");
            }
            else
            {
                Console.WriteLine("Nu ai castigat, mai incearca!");
            }

        }

        public static int[] LotoNumere()
        {
            Random rnd = new Random();
            int[] Loto = new int[6];

            for (int i = 0; i < 6; i++)
            {
                int numarRand = rnd.Next(1, 50);
                Loto[i] = numarRand;
                Console.WriteLine($"{Loto[i]}");
            }
            return Loto;
        }

        public static int[] CitesteNumere()
        {
            int[] numere = new int[6];
            bool inputValid = false;

            while (!inputValid)
            {
                Console.WriteLine("Introduceti 6 numere intregi separate prin spatiu:");

                string input = Console.ReadLine();
                string[] numereString = input.Split(' ');

                if (numereString.Length != 6)
                {
                    Console.WriteLine("Input invalid. Trebuie sa introduci exact 6 numere separate prin spatiu.");
                    continue;
                }

                inputValid = true;

                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        numere[i] = int.Parse(numereString[i]);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Input invalid. '{numereString[i]}' nu este un numar intreg valid.");
                        inputValid = false;
                        break;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine($"Input invalid. '{numereString[i]}' este prea mare sau prea mic.");
                        inputValid = false;
                        break;
                    }
                }
            }

            return numere;
        }

        public static bool VerificareCastig(int[] numereJucator, int[] numereLoto)
        {
            List<int> lotoList = new List<int>(numereLoto);

            
            for (int i = 0; i < numereJucator.Length; i++)
            {
                bool nrGasit = false;

                for (int j = 0; j < lotoList.Count; j++)
                {
                    if (numereJucator[i] == lotoList[j])
                    {
                        nrGasit = true;
                        lotoList.RemoveAt(j); 
                        break;
                    }
                }

                
                if (!nrGasit)
                {
                    return false;
                }
            }

            return true;
        }
    }
}


