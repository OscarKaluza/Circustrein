using Circustrein.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class Animal
{
    public string Name { get; set; }
    public int Size { get; set; }
    public bool IsCarnivore { get; set; }

    public Animal(string name, int size, bool isCarnivore)
    {
        Name = name;
        Size = size;
        IsCarnivore = isCarnivore;
    }
}

public class Wagon
{
    private List<Animal> animals = new List<Animal>();
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

    public void ListAnimals()
    {
        Console.WriteLine("Animals in the wagon:");
        foreach (var animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Size: {animal.Size}, IsCarnivore: {animal.IsCarnivore}");
        }
    }
}

class Program
{
    Testcases Testcases = new Testcases();
    static void Main()
    {
        List<Wagon> wagons = new List<Wagon>();

        Animal animal1 = new Animal("smallCarnivore1", 1, true);
        Animal animal2 = new Animal("smallCarnivore2", 1, true);
        Animal animal3 = new Animal("smallCarnivore3", 1, true);
        Animal animal4 = new Animal("smallCarnivore4", 1, true);
        Animal animal5 = new Animal("smallCarnivore5", 1, true);
        Animal animal6 = new Animal("smallCarnivore6", 1, true);
        Animal animal7 = new Animal("smallCarnivore7", 1, true);

        Animal animal8 = new Animal("mediumCarnivore1", 3, true);
        Animal animal9 = new Animal("mediumCarnivore2", 3, true);
        Animal animal10 = new Animal("mediumCarnivore3", 3, true);

        Animal animal11 = new Animal("largeCarnivore1", 5, true);
        Animal animal12 = new Animal("largeCarnivore2", 5, true);
        Animal animal13 = new Animal("largeCarnivore3", 5, true);

        Animal animal14 = new Animal("mediumHerbivore1", 3, false);
        Animal animal15 = new Animal("mediumHerbivore2", 3, false);
        Animal animal16 = new Animal("mediumHerbivore3", 3, false);
        Animal animal17 = new Animal("mediumHerbivore4", 3, false);
        Animal animal18 = new Animal("mediumHerbivore5", 3, false);

        Animal animal19 = new Animal("LargeHerbivore1", 5, false);
        Animal animal20 = new Animal("LargeHerbivore2", 5, false);
        Animal animal21 = new Animal("largeHerbivore3", 5, false);
        Animal animal22 = new Animal("largeHerbivore4", 5, false);
        Animal animal23 = new Animal("largeHerbivore5", 5, false);
        Animal animal24 = new Animal("largeHerbivore6", 5, false);




        foreach (var animal in new Animal[] { animal1, animal2, animal3, animal4, animal5, animal6, animal7, animal8, animal9, animal10, animal11, animal12, animal13, animal14, animal15, animal16, animal17, animal18, animal19, animal20, animal21, animal22, animal23, animal24})
        {
            bool animalAdded = false;
            foreach (var wagon in wagons)
            {
                if (wagon.CanAddAnimal(animal))
                {
                    if (wagon.AddAnimal(animal))
                    {
                        Console.WriteLine($"Added {animal.Name} to an existing wagon.");
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
                    Console.WriteLine($"Added {animal.Name} to a new wagon.");
                    wagons.Add(newWagon);
                }
            }
        }

        Console.WriteLine("\nAnimals in each wagon:");
        for (int i = 0; i < wagons.Count; i++)
        {
            Console.WriteLine($"Wagon {i + 1}:");
            wagons[i].ListAnimals();
            Console.WriteLine();
        }
    }
}
