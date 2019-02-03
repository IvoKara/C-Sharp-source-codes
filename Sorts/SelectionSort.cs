using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    static class Selection
    {
        public static void Sort<T>(T[] collection) where T: IComparable
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (Less(collection[j], collection[min_index]))
                        min_index = j;
                }
                Swap<T>(collection, min_index, i);
            }
        }

        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) > 0;
        }

        private static void Swap<T> (T[] collection, int from, int to)
        {
            T temp = collection[from];
            collection[from] = collection[to];
            collection[to] = temp;
        }
    }
}
