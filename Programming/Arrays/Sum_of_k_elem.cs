using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_k_elem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            sequence[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (i <= k)
                {
                    sequence[i] = sequence.Sum();
                }
                else
                {
                    for (int j = i - k; j < i; j++)
                        sequence[i] += sequence[j];
                }               
            }
            foreach(var number in sequence)
                Console.Write(number + " ");
        }
    }
}
