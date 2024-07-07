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

            string[] input = { "QWERTYUIOPASDFGHJKLZXCVBNM", "ABC", "112" };
          
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Pentru sirul de caractere: {input[i]}");

                bool rezultat = Pangrama(input[i]);

                if (rezultat)
                {
                    Console.WriteLine("Inputul este o pangrama!");
                }
                else
                {
                    Console.WriteLine("Inputul nu este o pangrama!");
                }
            }
            
        }

      public static bool Pangrama(string input)
        {
            if (input == null || input == "")
            {
                return false;
            }

            string lowerCase = input.ToLower();

            
            bool[] literePrezente = new bool[26];

            
            for(int i = 0; i < lowerCase.Length; i++)
            {
                char caracter = lowerCase[i];

                if (caracter >= 'a' && caracter <= 'z')
                {
                    
                    int index = caracter - 'a';
                    literePrezente[index] = true;
                }
            }

            
            for (int i = 0; i < 26; i++)
            {
                if (!literePrezente[i])
                {
                    
                    return false;
                }
            }

         
            return true;
        }

    }
}
