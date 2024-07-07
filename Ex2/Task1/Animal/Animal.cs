using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Clasa de baza pentru animale
    public abstract class Animal
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();
    }
}
