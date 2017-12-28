using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTop('\\', '/', n);
            PrintMid(n);
            PrintBottom('/', '\\', n);
        }

        static void PrintTop(char left, char right, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{new string(' ', (n*2)-(i*2))}{new string(left, n - i)}{new string('-', 6 * i)}{new string(right, n - i)}");
        }

        static void PrintBottom(char left, char right, int n)
        {
            for (int i = n-1; i >= 0; i--)
                Console.WriteLine($"{new string(' ', (n * 2) - (i * 2))}{new string(left, n - i)}{new string('-', 6 * i)}{new string(right, n - i)}");
        }

        static void PrintMid(int n)
        {
            int newLen = n - 1;
            if (n % 2 != 0)
                newLen--;
            for (int i = 0; i < newLen; i++)
            {
                if (i == newLen/2)
                    Console.WriteLine($"|{new string('~', n-1)}{new string('/',(n*4-6)/2)} ESTD {new string('\\', (n * 4 - 6) / 2)}{new string('~', n - 1)}|");
                else
                    Console.WriteLine($"|{new string('-', n - 1)}{new string('#', n * 4)}{new string('-', n - 1)}|");
            }
        }
    }
}
