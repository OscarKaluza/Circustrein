namespace Circustrein.Tests
{
    public class WagonTests
    {
        [Fact]
        public void Cannot_add_meat_eating_animal_when_big_carnivore_is_present()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal("Timo", 5, true));

            bool canAdd = wagon.CanAddAnimal(new Animal("Oscar", 3, true));

            Assert.False(canAdd);
        }
        
        [Fact]
        public void Cannot_add_small_herbivore_when_medium_carnivore_is_present()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal("Timo", 3, true));

            bool canAdd = wagon.CanAddAnimal(new Animal("Oscar", 1, false));

            Assert.False(canAdd);
        }

        [Fact]
        public void Cannot_add_medium_herbivore_when_big_carnivore_is_present()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal("Timo", 5, true));

            bool canAdd = wagon.CanAddAnimal(new Animal("Oscar", 3, false));

            Assert.False(canAdd);
        }

        [Fact]
        public void Cannot_add_big_herbivore_when_big_carnivor_is_present()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal("Timo", 5, true));

            bool canAdd = wagon.CanAddAnimal(new Animal("Oscar", 5, false));

            Assert.False(canAdd);
        }

        [Fact]
        public void Cannot_add_medium_carnivore_when_small_carnivore_is_present()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal("Timo", 1, false));
            bool canAdd = wagon.CanAddAnimal(new Animal("Oscar", 3, true));

            Assert.False(canAdd);
        }

        [Fact]
        public void Can_add_bigger_herbivore_when_smaller_carnivore_is_present()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal("Timo", 3, true));

            bool canAdd = wagon.CanAddAnimal(new Animal("Oscar", 5, false));

            Assert.True(canAdd);
        }

        [Fact]
        public void add_small_carnivore_when_bigger_herbivore_is_present()
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal("Timo", 3, false));

            bool canAdd = wagon.CanAddAnimal(new Animal("Oscar", 1, true));

            Assert.True(canAdd);
        }

    }
}