using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal static class ExtensionForLinq
    {
        public static T PenultimateItem<T>(this IEnumerable<T> collection)
        {
            var list = collection.ToList();
            if (list.Count < 2 || list?.Count == null)
            {
                throw new ArgumentException("collection size less than 2 or null");
            }
            return list[list.Count - 2];
        }
    }
}
