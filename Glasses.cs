using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i > 0 && i < n - 1)
                {
                    Console.Write($"*{new string('/', 2*n - 2)}*");
                  if(i==(n-1)/2)
                        Console.Write(new string('|', n));
                  else
                        Console.Write(new string(' ', n));
                    Console.WriteLine($"*{new string('/', 2 * n - 2)}*");
                }
                else
                    Console.WriteLine($"{new string('*',2*n)}{new string(' ',n)}{new string('*', 2*n)}");
            }
        }
    }
}
