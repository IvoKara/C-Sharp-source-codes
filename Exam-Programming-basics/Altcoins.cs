using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altcoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var numBTC = double.Parse(Console.ReadLine());
            var moneyForBTC = double.Parse(Console.ReadLine());
            var currentBTC = double.Parse(Console.ReadLine());
            var neededET = double.Parse(Console.ReadLine());
            var neededNEO = double.Parse(Console.ReadLine());
            double diff = numBTC * (Math.Abs(moneyForBTC - currentBTC));
            double moneyForET = (7.5 / 100) * currentBTC;
            double moneyForNEO = 0.4 * moneyForET;
            double allCost = neededET * moneyForET + neededNEO * moneyForNEO;
            if (allCost <= diff)
            {
                Console.WriteLine($"Stefcho bought {neededET:f4}  Ethereum at a price of {moneyForET:f4}");
                Console.WriteLine($"Stefcho bought {neededNEO:f4} Neo at a price of {moneyForNEO:f4}");
                Console.WriteLine($"Stefcho has {Math.Round(diff - allCost, 2):f2} profits left to spend.");
            }
            else
            {
                Console.WriteLine("Stefcho does not have enough money to make this investment.");
                Console.WriteLine($"He needs {Math.Round(allCost - diff, 2):f2} more in profits.");
            }
        }
    }
}
