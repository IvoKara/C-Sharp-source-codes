using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productName = Console.ReadLine().Split();//{"Bread", "Juice", "Fruits", "Lemons"};
            
            long[] amount = new long[productName.Length];
            long[] testy = Console.ReadLine().Split().Select(long.Parse).ToArray();
            for (int i = 0; i < productName.Length; i++)
                amount[i] = 0;
            for (int i = 0; i < testy.Length; i++)
                amount[i] = testy[i];

            double[] value = new double[productName.Length];
            value = Console.ReadLine().Split().Select(double.Parse).ToArray(); //{2.34, 1.23, 3.42, 1.50};

            Dictionary<string, long> Amount = new Dictionary<string, long>();
            Dictionary<string, double> Value = new Dictionary<string, double>();
            for (int i = 0; i < productName.Length; i++)
            {
                Amount.Add(productName[i], amount[i]);
                Value.Add(productName[i], value[i]);
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "done")
                    break;
                if (int.Parse(command[1]) <= Amount[command[0]])
                {
                    Console.WriteLine($"{command[0]} x {command[1]} costs {int.Parse(command[1]) * Value[command[0]]:f2}");
                    Amount[command[0]] -= int.Parse(command[1]);
                }
                else
                {
                    Console.WriteLine("We do not have enough " + command[0]);
                }
            }
        }
    }
}
