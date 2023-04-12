using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal abstract class Human
    {
        public int Age { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Human(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract void Talk();
             
        public virtual void Move()
        {
            Console.WriteLine("I can move freely");
        }
    }
}
