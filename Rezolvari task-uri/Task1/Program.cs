using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.suma(-2, 1));
            Console.WriteLine(calculator.suma(2, 1, 2));
            Console.WriteLine(calculator.suma(2, 1, 3, 4));
            Console.WriteLine(calculator.suma(2, 1, 3, 4));

            int[] variabil = {1, 2, 3, 4, 5};
            Console.WriteLine(calculator.suma(variabil));

        }
    }

    public class Calculator
    {

        //metoda pentru suma
        public int suma(int a, int b)
        {
            while (b != 0)
            {
                if (b > 0)
                {
                    a++;
                    b--;
                }
                else
                {
                    a--;
                    b++;
                }
            }
            return a;
        }

        //overloading
        public int suma(int a, int b, int c)
        {
            return suma(suma(a, b), c);
        }

        public int suma(int a, int b, int c, int d)
        {
            return suma(suma(a, b), suma(c, d));
        }

        //numar variabil de parametri

        public int suma(int[] numere)
        {
            int rezultat = 0;

            for(int i = 0; i < numere.Length; i++)
            {
                rezultat += numere[i];
            }

            return rezultat;
        }
    }
}
