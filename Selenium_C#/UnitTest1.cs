namespace Selenium_C_
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup Method Executed");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1 Method Executed");
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2 Method Executed");
        }

        [TearDown]
        public void closebrowser()
        {
            Console.WriteLine("Close Method Executed");
        }
    }
}