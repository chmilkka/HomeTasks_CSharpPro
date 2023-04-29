namespace HomeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            var factory = new Factory<TestClass>();
            var testClass = factory.Create();

            testClass.DoubleWork();
        }
    }
}