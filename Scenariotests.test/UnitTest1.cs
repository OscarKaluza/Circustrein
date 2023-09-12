namespace Scenariotests.test
{
    public class UnitTest1
    {
        [Fact]
        public void TestCase1()
        {
            Wagon wagon = new Wagon();

            wagon.AddAnimal(new Animal("smallCarnivore1", 1, true));

        }
    }
}