using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mid = 2 * (n - 2) + 1;
            for (int i = 0; i < mid; i++)
            {
                char typeWing = '*';
                if (i % 2 != 0)
                    typeWing = '-';
                if (i < mid / 2)
                {
                    Console.Write(PrintWings(n - 2, '\\', typeWing, false));
                    Console.WriteLine(" {0}",PrintWings(n - 2, '/', typeWing, true));
                }
                else if (i == mid / 2)
                    Console.WriteLine(new string(' ', n - 1) + '@');
                else
                {
                    Console.Write(PrintWings(n - 2, '/', typeWing, false));
                    Console.WriteLine(' ' + PrintWings(n - 2, '\\', typeWing, true));
                }
            }
        }

        static string PrintWings(int len, char side, char wing, bool inBegin)
        {
            char begin = '\r';
            char end = side;
            if (inBegin)
            {
                begin = side;
                end = ' ';
            }
            return begin + new string(wing, len) + end;
        }
    }
}
