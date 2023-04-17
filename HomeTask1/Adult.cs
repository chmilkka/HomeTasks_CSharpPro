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
        public Adult(IdentityDocument id) : base(id)
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

        public void DoAdultWork()
        {
            Console.WriteLine("I can do adult work!");
        }
    }
}
