using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    internal class TestClass : IInterface1, IInterface2
    {
        public TestClass() { }
        public void DoSomething1()
        {
            Console.WriteLine("Hello from Interface1!");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Hello from Interface2!");
        }
    }
}
