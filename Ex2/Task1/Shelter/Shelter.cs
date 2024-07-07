using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    // Clasa pentru adapostul de animale
    public class Shelter
    {
        private List<Animal> animals;
        private int capacity;
        private Queue<int> availableIds;
        private int nextId;

        public Shelter(int capacity)
        {
            this.capacity = capacity;
            animals = new List<Animal>();
            availableIds = new Queue<int>();
            nextId = 1;
        }

        private int GetNextId()
        {
            if (availableIds.Count > 0)
            {
                return availableIds.Dequeue();
            }
            return nextId++;
        }

        private void ReleaseId(int id)
        {
            availableIds.Enqueue(id);
        }

        // Adaugare animal in adapost
        public void AddAnimal(Animal animal)
        {
            if (animals.Count < capacity)
            {
                animal.ID = GetNextId();
                animals.Add(animal);
                Console.WriteLine($"Animalul {animal.Name} (ID: {animal.ID}) a fost adaugat in adapost.");
            }
            else
            {
                Console.WriteLine("Adapostul este plin, nu se poate adauga animalul.");
            }
        }

        // Adoptare animal din adapost
        public void AdoptAnimal(Animal animal)
        {
            if (animals.Contains(animal))
            {
                animals.Remove(animal);
                ReleaseId(animal.ID);
                Console.WriteLine($"Animalul {animal.Name} (ID: {animal.ID}) a fost adoptat.");
            }
            else
            {
                Console.WriteLine($"Animalul {animal.Name} (ID: {animal.ID}) nu este in adapost.");
            }
        }

        // Afisare starea adapostului
        public void DisplayShelterStatus()
        {
            Console.WriteLine($"Capacitatea adapostului: {capacity}");
            Console.WriteLine($"Numarul de animale in adapost: {animals.Count}");
            Console.WriteLine("Animalele in adapost:");

            // Sortare animale dupa ID
            var sortedAnimals = animals.OrderBy(a => a.ID);
            foreach (var animal in sortedAnimals)
            {
                Console.WriteLine($"{animal.Name} (ID: {animal.ID}) - {animal.GetType().Name} - Sound: {animal.MakeSound()}");
            }
        }
    }
}
