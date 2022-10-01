using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal static class ExtentionArrayList
    {
        public static T[] GetArray<T>(this IEnumerable<T> arrayList)
        {
            T[] array = new T[arrayList.Count()];
            int i = 0;
            foreach (T item in arrayList)
            {
                array[i++] = item;
            }
            return array;
        }
    }
}
