using HomeTask1.Interface;
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
            Console.WriteLine($"{human.Id.Gender} {human.Id.FirstName} {human.Id.LastName} {human.Id.Age} y.o");
        }
        public static void DoCommonMethods(Human human)
        {
            human.Talk();
            human.Move();
        }
        public static void DoSpecialMethod1(IWork human)
        {
            human.DoAdultWork();
        }
        public static void DoSpecialMethod2(IGrow human)
        {
            human.Growing();
        }
    }
}
