using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "aaaavbb sdds cccfggd";

            Console.WriteLine(input);

            contorizare(input);
        }

       public static void contorizare(string input)
        {

            if(input == null || input == "")
            {
                Console.WriteLine("String gol!");
            }

            for(int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                 if(currentChar != ' ')
                {
                    int count = 1;

                    while (i+1 < input.Length && input[i+1] == currentChar)
                    {
                        count++;

                        i++;
                    }

                    Console.WriteLine($"Caracter curent:{currentChar} Numar aparitii:{count}");
                } else
                {
                    Console.WriteLine("");
                }
            }




        }
       
    }
}
