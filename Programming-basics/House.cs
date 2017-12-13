using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string roof = (n % 2 != 0) ? "*" : "**";
            for (int i = 1; i <= n; i++)
            {
                if (i <= (n + 1) / 2)
                {
                    var lines = n - roof.Length;
                    Console.WriteLine($"{new string('-', lines/2)}{roof}{new string('-', lines/2)}");
                    roof += "**";
                }
                else
                    Console.WriteLine($"|{new string('*', n - 2)}|");
            }
        }
    }
}
