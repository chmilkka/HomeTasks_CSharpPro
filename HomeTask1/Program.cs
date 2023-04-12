namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var child = new Kiddy(1, "Bob", "Brown");
            HumanHelper.Verification(child);
            HumanHelper.DoMethods(child);
            Console.WriteLine();

            var teen = new Teenager(16, "Mark", "Brown");
            HumanHelper.Verification(teen);
            HumanHelper.DoMethods(teen);
            Console.WriteLine();

            var adult = new Adult(38, "Tom", "Brown");
            HumanHelper.Verification(adult);
            HumanHelper.DoMethods(adult);
        }
    }
}