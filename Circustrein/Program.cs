using Circustrein;
using Circustrein.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;

class Program
{

    static void Main()
    {
        Wagon wagon = new Wagon();
        List<Animal> animals = new List<Animal>();

        animals.Add(new Animal("smallCarnivore1", 1, true));
        animals.Add(new Animal("mediumHerbivore1", 3, false));
        animals.Add(new Animal("MediumHerbivore2", 3, false));
        animals.Add(new Animal("mediumHerbivore3", 3, false));
        animals.Add(new Animal("largeHerbivore1", 5, false));
        animals.Add(new Animal("largeHerbivore2", 5, false));
        animals.Add(new Animal("LargeCarnivore", 5, true));

        List<Wagon> wagons = wagon.distributeWagons(animals);


        for (int i = 0; i < wagons.Count; i++)
        {
            Console.WriteLine($"Wagon {i + 1}:");
            Console.WriteLine("Animals in the wagon:");
            foreach (var animal in wagons[i].animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Size: {animal.Size}, IsCarnivore: {animal.IsCarnivore}");
            }
        }

    }
}

