using HunterDaimonTestProject.CoolStuff;

namespace HunterDaimonTestProject.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            CoolNewThing thing = new CoolNewThing();
            Console.WriteLine("Enter Name");
            String name = Console.ReadLine();
            thing.doStuff(name);
            Assert.Pass();
        }
    }
}