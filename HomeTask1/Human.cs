using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal abstract class Human
    {
        
        public Human(IdentityDocument id)
        {
            Id = id;
        }
        public IdentityDocument Id { get; set; }

        public abstract void Talk();
             
        public virtual void Move()
        {
            Console.WriteLine("I can move freely");
        }
    }
}
