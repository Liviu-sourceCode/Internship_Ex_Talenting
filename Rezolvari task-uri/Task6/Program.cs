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
           
            List<string> listaNume = new List<string> {"Horia" , "Alonso", "Olof", "Alina", "Matei", "Iza", "Ion"};

                 Lista.listaNume(listaNume, 'a');
                 Console.WriteLine("");

                 Lista.cinciLitere(listaNume);
                 Console.WriteLine("");

                 Lista.numeLung(listaNume);
                 Console.WriteLine("");

                 Lista.numeScurt(listaNume);
                 Console.WriteLine("");

                 Lista.aparitieNume(listaNume);
                 Console.WriteLine("");
        }
    }

    public class Lista
    {
        //Afiseaza alfabetic toate numele care contin litera 'a'
        public static void listaNume(List<string> lista, char caracter)
        {

            for(int i = 0; i < lista.Count; i++)
            {
                if (!lista[i].ToLower().Contains(caracter))
                {
                    lista.RemoveAt(i);
                }
            }

            lista.Sort();

            Console.WriteLine("Elementele filtrate si sortate care contin litera 'a':");

            foreach (string elem in lista)
            {
                Console.WriteLine(elem);
            }

        }

        //Afiseaza numele >= 5 litere
        public static void cinciLitere(List<string> listaNume)
        {
            Console.WriteLine("Numele mai mari sau egale cu 5 litere sunt:");
            for (int i = 0; i < listaNume.Count; i++)
            {
                if (listaNume[i].Length >= 5)
                {
                    Console.WriteLine(listaNume[i]);
                }
            }
        }

        //Afiseaza cele mai lungi nume
        public static void numeLung(List<string> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("Lista nu poate fi null sau goala.");
            }

            int maxLength = lista.Max(s => s.Length);
            
            List<string> result = lista.Where(s => s.Length == maxLength).ToList();

            Console.WriteLine("Stringurile cu lungimea maxima:");
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        //Afiseaza cele mai scurte nume
        public static void numeScurt(List<string> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("Lista nu poate fi null sau goala.");
            }
           
            int minLength = lista.Min(s => s.Length);
            
            List<string> result = lista.Where(s => s.Length == minLength).ToList();

            Console.WriteLine("Stringurile cu lungimea minima:");
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        //Afiseaza de cate ori apare numele 'Alina'
        public static void aparitieNume(List<string> listaNume)
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
}
