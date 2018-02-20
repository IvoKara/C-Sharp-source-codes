using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeral_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            NumeralConverter(input[1], input[0]);
        }

        static void NumeralConverter(int number, int givenBase)
        {
            List<int> newNumber = new List<int>();
            while(number > 0)
            {
                newNumber.Add(number % givenBase);
                number /= givenBase;
            }
            newNumber.Reverse();
            Console.WriteLine(string.Join("", newNumber));
        }
    }
}
