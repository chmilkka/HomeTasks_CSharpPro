using HomeTask1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class Kiddy : Human, ICry
    {
        public Kiddy(int age, string firstName, string lastName) : base(age, firstName, lastName)
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

        public void Cry()
        {
            Console.WriteLine("AAaaAAbbaba :(");
        }
    }
}
