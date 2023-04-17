using HomeTask1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class Kiddy : Human, IGrow
    {
        public Kiddy(IdentityDocument id) : base(id)
        {
        }

        public override void Talk()
        {
            Console.WriteLine(@"Nya-nya! Ba-ba! Ma-ma! \(^_^)/");
        }
        public override void Move()
        {
            Console.WriteLine(@"I can only crawl!");
        }

        public void Growing()
        {
            Console.WriteLine("I'm a child, I'm growing up fast!");
        }
    }
}
