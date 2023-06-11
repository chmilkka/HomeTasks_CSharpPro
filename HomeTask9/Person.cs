﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask9
{
    internal class Person
    {
        public Person()
        {
            
        }
        [DisplayName]
        public string FirstName { get; set; }
        [DisplayName]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public Person(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
