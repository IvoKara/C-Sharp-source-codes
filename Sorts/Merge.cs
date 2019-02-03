using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sort
{
    static class Merge<T> where T : IComparable
    {
        private static T[] aux;

        public static void Sort(T[] arr) 
        {
            aux = new T[arr.Length];
            Sort(arr, 0, arr.Length - 1);
        }

        private static void MergeArr(T[] arr, int lo, int mid, int hi)
        {
            if(Less(arr[mid], arr[mid+1]))
            {
                return;
            }
            for(int index = lo; index <= hi; index++)
            {
                aux[index] = arr[index];
            }
            int i = lo;
            int j = mid + 1;
            for(int k = lo; k <= hi; k++)
            {
                if(i > mid)
                {
                    arr[k] = aux[j++];
                }
                else if(j > hi)
                {
                    arr[k] = aux[i++];
                }
                else if(Less(aux[i], aux[j]))
                {
                    arr[k] = aux[i++];
                }
                else
                {
                    arr[k] = aux[j++];
                }
            }
        }

        private static void Sort(T[] arr, int l, int r)
        {
            if(r - l <= 1)
            {
                if(Less(arr[r], arr[l]))
                {
                    Swap(arr, r, l);
                }
                return;
            }
            int mid = (l + r) / 2;
            Sort(arr, l, mid);
            Sort(arr, mid + 1, r);
            MergeArr(arr, l, mid, r);
        }
        private static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        private static void Swap(T[] collection, int from, int to)
        {
            T temp = collection[from];
            collection[from] = collection[to];
            collection[to] = temp;
        }
    }
}
