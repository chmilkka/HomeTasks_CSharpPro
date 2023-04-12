using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal static class HumanHelper
    {
        public static void Verification(Human human)
        {
            Console.WriteLine($"{human.FirstName } {human.LastName } {human.Age } y.o");
        }
        public static void DoMethods(Human human)
        {
            if (human is Kiddy child)
            {
                child.Talk();
                child.Move();
                child.Cry();
            }
            if (human is Teenager teen)
            {
                teen.Talk();
                teen.Move();
                teen.Study();
            }
            if (human is Adult adult)
            {
                adult.Talk();
                adult.Move();
                adult.Work();
            }
        }
    }
}
