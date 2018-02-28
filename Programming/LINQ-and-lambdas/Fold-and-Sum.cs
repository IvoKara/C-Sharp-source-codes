using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = list.Count / 4;
            List<int> toAdd = list.Take(k).Reverse().Concat(list.Skip(list.Count - k).Reverse()).ToList();
            list.RemoveRange(0, k);
            list.RemoveRange(list.Count - k, k);
            Console.WriteLine(string.Join(" ", list.Zip(toAdd, (x, y) => x + y)));
        }
    }
}
