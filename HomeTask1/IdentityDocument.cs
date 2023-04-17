using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    internal class IdentityDocument
    {
        public IdentityDocument(Gender gender,string firstName, string lastName, int age)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Gender Gender { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
    }
}
