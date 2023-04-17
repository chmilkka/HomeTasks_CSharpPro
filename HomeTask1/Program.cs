namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var child = new Kiddy(new IdentityDocument (Gender.Male, "Bob", "Brown", 1));
            HumanHelper.Verification(child);
            HumanHelper.DoCommonMethods(child);
            HumanHelper.DoSpecialMethod2(child);
            Console.WriteLine();

            var teen = new Teenager(new IdentityDocument (Gender.Female, "Jane", "Brown", 16));
            HumanHelper.Verification(teen);
            HumanHelper.DoCommonMethods(teen);
            HumanHelper.DoSpecialMethod1(teen);
            HumanHelper.DoSpecialMethod2(teen);
            Console.WriteLine();

            var adult = new Adult(new IdentityDocument (Gender.Male, "Tom", "Brown", 38));
            HumanHelper.Verification(adult);
            HumanHelper.DoCommonMethods(adult);
            HumanHelper.DoSpecialMethod1(adult);

        }
    }
}