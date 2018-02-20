using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_seen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] count = new int[input.Max() + 1];

            for (int i = 0; i < input.Length; i++)
                count[input[i]]++;

            for (int i = 0; i < input.Length; i++)
            {
                if (count[input[i]] == count.Max())
                {
                    Console.WriteLine(input[i]);
                    return;
                }
            }
        }

    }
}
