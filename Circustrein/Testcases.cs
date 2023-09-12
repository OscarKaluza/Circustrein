using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Tests
{
    public class Testcases
    {
        List<Animal> testCase7;

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

        public List<Animal> testCases()
        {
            testCase7 = new List<Animal>() { animal1, animal2, animal3, animal4, animal5, animal6, animal7, animal8, animal9, animal10, animal11, animal12, animal13, animal14, animal15, animal16, animal17, animal18, animal19, animal20, animal21, animal22, animal23, animal24 };

            return testCase7;
        }
    }
}
