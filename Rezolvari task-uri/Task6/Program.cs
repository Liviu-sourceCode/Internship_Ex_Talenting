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

                 ListaNume(listaNume);
                 Console.WriteLine("");

                 cinciLitere(listaNume);
                 Console.WriteLine("");

                 numeLung(listaNume);
                 Console.WriteLine("");

                 numeScurt(listaNume);
                 Console.WriteLine("");

                 aparitieNume(listaNume);

        }

        public static void ListaNume(List<string> lista)
        {
            
            string caracter = "a";

            List<string> listaFiltrata = new List<string>();

            
            caracter = caracter.ToLower();

            
            foreach (string element in lista)
            {
                if (element.ToLower().Contains(caracter))
                {
                    listaFiltrata.Add(element);
                }
            }
           
            listaFiltrata.Sort();

            Console.WriteLine("Elementele filtrate si sortate care contin litera 'a':");

            foreach (string elem in listaFiltrata)
            {
                Console.WriteLine(elem);
            }

        }

        public static void cinciLitere(List<string> listaNume)
        {
            Console.WriteLine("Numele mai mari sau egale cu 5 litere sunt:");
            for(int i = 0; i < listaNume.Count; i++)
            {
                if (listaNume[i].Length >= 5)
                {
                    Console.WriteLine(listaNume[i]);
                }
            }
        }

        public static void numeLung(List<string> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("Lista nu poate fi null sau goala.");
            }

            // gaseste lungimea maxima a unui string
            int maxLength = lista.Max(s => s.Length);

            // Filtreaza si adauga in 'result' stringurile cu lungimea maxima
            List<string> result = lista.Where(s => s.Length == maxLength).ToList();

            Console.WriteLine("Stringurile cu lungimea maxima:");
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }            
        }

        public static void numeScurt(List<string> lista)
        {
            if (lista == null || lista.Count == 0)
            {
                throw new ArgumentException("Lista nu poate fi null sau goala.");
            }

            // Gaseste lungimea celui mai mic string din lista
            int minLength = lista.Min(s => s.Length);

            // imi filtreaza si adauga in 'result' stringurile cu lungimea minima
            List<string> result = lista.Where(s => s.Length == minLength).ToList();

            Console.WriteLine("Stringurile cu lungimea minima:");
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        public static void aparitieNume(List<string> listaNume)
        {
            string nume = "Alina";
            int count = 0;
            for(int i = 0; i < listaNume.Count; i++)
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
