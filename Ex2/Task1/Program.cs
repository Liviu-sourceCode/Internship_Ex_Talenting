using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Cream un adapost cu o capacitate de 5 locuri
                Shelter shelter = new Shelter(6);
                Dog dog1 = new Dog("Rust");
                Dog dog2 = new Dog("Dingo");
                Cat cat1 = new Cat("Helga");
                Cat cat2 = new Cat("Smaranda");
                Cat cat3 = new Cat("Shanon");

                // Adaugam cativa caini si pisici in adapost
                shelter.AddAnimal(dog1);
                shelter.AddAnimal(dog2);
                shelter.AddAnimal(cat1);
                shelter.AddAnimal(cat2);
                shelter.AddAnimal(cat3);

                // Afisam starea adapostului
                Console.WriteLine("Starea adapostului dupa adaugarea initiala:");
                shelter.DisplayShelterStatus();
                Console.WriteLine();

                // Adoptam un animal din adapost
              //  shelter.AdoptAnimal(cat2);
                shelter.AdoptAnimal(cat1);

                // Afisam starea adapostului dupa adoptare
                Console.WriteLine("Starea adapostului dupa adoptare:");
                shelter.DisplayShelterStatus();
                Console.WriteLine();

                // Incercam sa adaugam un animal cand adapostul este plin
                shelter.AddAnimal(new Cat("Fluffy"));
                shelter.DisplayShelterStatus();
           
        }
    }
    
}
