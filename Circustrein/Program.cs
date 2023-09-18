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
        List<Animal> Scenario1 = new List<Animal>();

        Scenario1.Add(new Animal("smallCarnivore1", 1, true));
        Scenario1.Add(new Animal("mediumHerbivore1", 3, false));
        Scenario1.Add(new Animal("MediumHerbivore2", 3, false));
        Scenario1.Add(new Animal("mediumHerbivore3", 3, false));
        Scenario1.Add(new Animal("largeHerbivore1", 5, false));
        Scenario1.Add(new Animal("largeHerbivore2", 5, false));
        Scenario1.Add(new Animal("LargeCarnivore", 5, true));

        List<Animal> Scenario2 = new List<Animal>();

        Scenario2.Add(new Animal("smallCarnivore1", 1, true));
        Scenario2.Add(new Animal("smallHerbivore1", 1, false));
        Scenario2.Add(new Animal("smallHerbivore2", 1, false));
        Scenario2.Add(new Animal("smallHerbivore3", 1, false));
        Scenario2.Add(new Animal("smallHerbivore4", 1, false));
        Scenario2.Add(new Animal("smallHerbivore5", 1, false));
        Scenario2.Add(new Animal("mediumHerbivore1", 3, false));
        Scenario2.Add(new Animal("mediumHerbivore2", 3, false));
        Scenario2.Add(new Animal("largeHerbivore1", 5, false));


        List<Wagon> wagons = Wagon.distributeWagons(Scenario2);

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

