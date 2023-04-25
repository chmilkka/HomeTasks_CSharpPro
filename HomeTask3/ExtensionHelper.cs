using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    internal static class ExtensionHelper
    {
        public static void DoubleWork<T>(this T item) where T : IInterface1, IInterface2
        {
            item.DoSomething1();
            item.DoSomething2();
        }
    }
}
