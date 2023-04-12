using HomeTask1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class Teenager : Human, IStudy
    {
        public Teenager(int age, string firstName, string lastName) : base(age, firstName, lastName)
        {
        }

        public override void Talk()
        {
            Console.WriteLine(@"Hi, I`m a teen! \('_')/");
        }

        public override void Move()
        {
            base.Move();
        }

        public void Study()
        {
            Console.WriteLine("I`m studing :(");
        }
    }
}
