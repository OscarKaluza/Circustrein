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
                if (existingAnimal.IsCarnivore || existingAnimal.IsCarnivore && existingAnimal.Size < animal.Size)
                {
                    return false;
                }
            }
        }
        else if (animal.IsCarnivore)
        {
            foreach (var existingAnimal in animals)
            {
                if (existingAnimal.IsCarnivore == false && existingAnimal.Size > animal.Size)
                {
                    return true;
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
    static void Main()
    {
        List<Wagon> wagons = new List<Wagon>();

        //Animal lion = new Animal("Lion", 5, true);
        //Animal zebra = new Animal("Zebra", 3, false);
        //Animal rabbit = new Animal("Rabbit", 1, false);
        //Animal tiger = new Animal("Tiger", 5, true);
        //Animal elephant = new Animal("Elephant", 5, false);
        //Animal dog = new Animal("Dog", 1, true);

        Animal animal1 = new Animal("smallCarnivore1", 1, true);
        Animal animal7 = new Animal("smallCarnivore2", 1, true);

        Animal animal2 = new Animal("MediumCarnivore1", 3, true);
        Animal animal3 = new Animal("LargeCarnivore1", 5, true);
        Animal animal4 = new Animal("smallHerbivore1", 1, false);
        Animal animal5 = new Animal("MediumHerbivore1", 3, false);
        Animal animal8 = new Animal("MediumHerbivore2", 3, false);
        Animal animal9 = new Animal("MediumHerbivore3", 3, false);
        Animal animal10 = new Animal("MediumHerbivore4", 3, false);
        Animal animal11 = new Animal("MediumHerbivore5", 3, false);

        Animal animal6 = new Animal("LargeHerbivore3", 5, false);



        foreach (var animal in new Animal[] { /*lion, zebra, rabbit, tiger, elephant, dog*/ animal1, animal2, animal3, animal4, animal5, animal6, animal7, animal8, animal9, animal10, animal11})
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
            Console.WriteLine($"Wagon {i}:");
            wagons[i].ListAnimals();
            Console.WriteLine();
        }
    }
}
