using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Swap(-32,3);
            
        }

        public static void Swap(int a, int b)
        {
            Console.WriteLine($"Afisare normala: a = {a}, b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Afisare dupa schimbare: a = {a}, b = {b}");
        }

    }
}
