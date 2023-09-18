using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {
        public List<Animal> animals = new List<Animal>();
        private int currentSize = 0;
        private const int MaxSize = 10;

        public bool CanAddAnimal(Animal animal)
        {
            if (animal.IsCarnivore)
            {
                foreach (var existingAnimal in animals)
                {
                    if (existingAnimal.IsCarnivore || existingAnimal.IsCarnivore == false && existingAnimal.Size < animal.Size)
                    {
                        return false;
                    }
                }

            }
            else if (animal.IsCarnivore == false)
            {
                foreach (var existingAnimal in animals)
                {
                    if (existingAnimal.IsCarnivore && existingAnimal.Size >= animal.Size)
                    {
                        return false;
                    }
                }
            }

            return currentSize + animal.Size <= MaxSize;
        }

        public bool AddAnimal(Animal animal)
        {
            if (CanAddAnimal(animal))
            {
                animals.Add(animal);
                currentSize += animal.Size;
                return true;
            }
            else
            {
                return false;
            }
        }


        static public List<Wagon> distributeWagons(List<Animal> animals)
        {
            List<Wagon> wagons = new List<Wagon>();

            foreach (var animal in animals)
            {
                bool animalAdded = false;
                foreach (var wagon in wagons)
                {
                    if (wagon.CanAddAnimal(animal))
                    {
                        if (wagon.AddAnimal(animal))
                        {
                            animalAdded = true;
                            break;
                        }
                    }
                }

                if (!animalAdded)
                {
                    Wagon newWagon = new Wagon();
                    if (newWagon.AddAnimal(animal))
                    {
                        wagons.Add(newWagon);
                    }
                }
            }

            return wagons;
        }
    }
}
