using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] input = new int[n];

            for (int i = 0; i < n; i++)
                input[i] = int.Parse(Console.ReadLine());
            var max = input.Max();
            var sum = input.Sum() - max;
            if (max == sum)
            {
                Console.WriteLine($"Yes\nSum = {max}");
                return;
            }
            Console.WriteLine($"No\nDiff = {Math.Abs(max - sum)}");
        }
    }
}
