using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy_and_ThenBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> market = new Dictionary<string, decimal>();
            market.Add("tomatoes", 2.40M);
            market.Add("potatoes", 1.50M);
            market.Add("cucumbers", 5.10M);
            market.Add("peppers", 1.50M);
            
            foreach(var products in market.OrderBy(product => product.Value).ThenBy(product => product.Key))
                Console.WriteLine(products.Key + " " + products.Value);
        }
    }
}
