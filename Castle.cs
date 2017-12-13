using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = height * 2;
            int hatsLen = height / 2;
            string hats = new string('^', hatsLen);
            int roofLen = width - 4 - hatsLen * 2;
            string roof = new string('_', roofLen);
            Console.WriteLine($"/{hats}\\{roof}/{hats}\\");
            for (int i = 0; i < height-3; i++)
                Console.WriteLine($"|{new string(' ',width-2)}|");
            Console.WriteLine($"|{new string(' ', hatsLen+1)}{roof}{new string(' ', hatsLen+1)}|");
            Console.WriteLine($"\\{new string('_', hatsLen)}/{new string(' ', roofLen)}\\{new string('_', hatsLen)}/");
        }
    }
}
