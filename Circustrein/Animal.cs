using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
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
}
