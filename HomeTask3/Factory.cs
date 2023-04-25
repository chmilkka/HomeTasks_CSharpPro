using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    internal class Factory<T> where T : class, new()
    {
        public T Create()
        {
            return new T();
        }     
    }
}
