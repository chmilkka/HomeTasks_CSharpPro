using HomeTask1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class Adult : Human, IWork
    {
        public Adult(int age, string firstName, string lastName) : base(age, firstName, lastName)
        {
        }

        public override void Talk()
        {
            Console.WriteLine(@"Hi, I`m an adult! \(o_0)/");
        }
        public override void Move()
        {
            base.Move();
        }
        public void Work()
        {
            Console.WriteLine("I`m working :(");
        }
    }
}
