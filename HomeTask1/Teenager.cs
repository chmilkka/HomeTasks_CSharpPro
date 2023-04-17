using HomeTask1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class Teenager : Human, IWork, IGrow
    {
        public Teenager(IdentityDocument id) : base(id)
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

        public void DoAdultWork()
        {
            Console.WriteLine("I can do adult work, but I`m a teen!");
        }

        public void Growing()
        {
            Console.WriteLine("I'm a teen, I'm also growing!");
        }
    }
}
