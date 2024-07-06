using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listaNume = new List<string> {"Ion", "Alina", "Andrei"};

            TratareExceptiiSiAfisare.ProceseazaListaSiAfiseaza(listaNume);

        }
    }
    //Clasa care trateaza sarcinile
    public class Lista
    {
        //Afiseaza alfabetic toate numele care contin litera 'a'
        public static void SortareNume(List<string> lista, char caracter)
        {
            var result = lista.Where(s => s.ToLower().Contains(caracter)).OrderBy(s => s).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine($"Nu există cuvinte cu litera '{caracter}'!");
            }
            else
            {
                Console.WriteLine($"Elementele filtrate si sortate care contin litera '{caracter}':");
                foreach (string elem in result)
                {
                    Console.WriteLine(elem);
                }

            }
        }
        //Afiseaza numele >= 5 litere
        public static void CinciLitere(List<string> listaNume)
        {
            Console.WriteLine("Numele mai mari sau egale cu 5 litere sunt:");

            int count = 0;
            for (int i = 0; i < listaNume.Count; i++)
            {
                if (listaNume[i].Length >= 5)
                {
                    count++;
                    Console.WriteLine(listaNume[i]);
                }
            }
            if (count == 0) 
            {
                Console.WriteLine("Nu exista cuvinte de cel putin 5 litere!");
            }
        }
        //Afiseaza cele mai lungi nume
        public static void NumeLung(List<string> lista)
        {
            if(lista.Count == 1)
            {
                Console.WriteLine($"Stringul cu cel mai lung nume: {lista[0]}");
            }
            else
            {
                int maxLength = lista.Max(s => s.Length);

                List<string> result = lista.Where(s => s.Length == maxLength).ToList();

                Console.WriteLine("Stringurile cu lungimea maxima:");
                foreach (string str in result)
                {
                    Console.WriteLine(str);
                }
            }
           
        }
        //Afiseaza cele mai scurte nume
        public static void NumeScurt(List<string> lista)
        {

            if(lista.Count == 1)
            {
                Console.WriteLine($"Stringurile cu lungimea minima: {lista[0]}");
            }
            else 
            {
                int minLength = lista.Min(s => s.Length);

                List<string> result = lista.Where(s => s.Length == minLength).ToList();

                Console.WriteLine("Stringurile cu lungimea minima:");
                foreach (string str in result)
                {
                    Console.WriteLine(str);
                }
            }
            
        }
        //Afiseaza de cate ori apare numele 'Alina'
         public static void AparitieNume(List<string> listaNume)
        {
            string nume = "Alina";
            int count = 0;
            for (int i = 0; i < listaNume.Count; i++)
            {
                if (listaNume[i] == nume)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numarul de aparitii al cuvantului 'Alina':{count}");
        }
    }    
    //Clasa care trateaza exceptiile si apeleaza metodele
    public class TratareExceptiiSiAfisare : Lista
    {
        public static void ProceseazaListaSiAfiseaza(List<string> lista)
        {

            if (lista == null || lista.Count == 0 || lista.Any(s => string.IsNullOrEmpty(s) || !s.All(char.IsLetter)))
            {
                throw new ArgumentException("Lista contine cel putin un string invalid!");
            }
                SortareNume(lista, 'a');
                Console.WriteLine();
                CinciLitere(lista);
                Console.WriteLine();
                NumeLung(lista);
                Console.WriteLine();
                NumeScurt(lista);
                Console.WriteLine();
                AparitieNume(lista);
                Console.WriteLine();           
        }       
        }    
}
