using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    static class Insertion
    {
        public static void Sort<T>(T[] collection) where T : IComparable
        {
            for (int i = 1; i < collection.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Less(collection[j], collection[j - 1]))
                    {
                        Swap(collection, j, j - 1);
                    }
                }
                
            }
        }

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        private static void Swap<T>(T[] collection, int from, int to)
        {
            T temp = collection[from];
            collection[from] = collection[to];
            collection[to] = temp;
        }
    }
}
