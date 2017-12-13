using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            for (int i = 0; i <= size; i++)
            {
                Console.WriteLine($"{new string(' ', size - i)}{new string('*', i)}" +
                    $" | {new string('*', i)}{new string(' ', size - i)}");
            }
        }
    }
}
