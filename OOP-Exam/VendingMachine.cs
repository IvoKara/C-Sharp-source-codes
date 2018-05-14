using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class VendingMachine
    {
        private string id;
        private List<Product> inVendingMachine;
        private double totalSalesAmount = 0;
        private double battery = 100;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Battery
        {
            get { return battery; }
        }

        public double TotalSalesAmount
        {
            get { return totalSalesAmount; }
        }

        public VendingMachine(string id) : this(id, new List<Product>())
        {
            this.id = id;
        }

        public VendingMachine(string id, List<Product> products) 
        {
            this.inVendingMachine = products;
        }

        public override string ToString()
        {
            return $"Machine: {id} has the following available products:\n" +
            string.Join("\n", inVendingMachine) +
            $"\n---- With total sales amount: {totalSalesAmount:f2}.";
        }

        public void AddProduct(Product toAdd)
        {
            inVendingMachine.Add(toAdd);
        }

        public void Recharge()
        {
            this.battery = 100;
        }

        public void ClearSales()
        {
            totalSalesAmount = 0;
        }

        public int CheckProductQuantityOfGivenType(string type)
        {
            return inVendingMachine.Where(x => x.Type == type).Count();
        }

        public void RemoveProduct(string productName)
        {
            inVendingMachine.Remove(inVendingMachine.Find(x => x.Name == productName));
        }

        public Product GetMostExpensiveProduct()
        {
            return inVendingMachine.OrderByDescending(x => x.Price).ToList()[0];
        }

        public string SellProduct(string productName)
        {
            Product toSell = inVendingMachine.Find(x => x.Name == productName);
            battery -= toSell.Price * 0.8 + 2;
            Product.OrdersCount++;
            totalSalesAmount += toSell.Price;
            RemoveProduct(toSell.Name);
            return $"{toSell.Name} for {toSell.Price}lv.";
        }

        public void RemoveAllProductsOfGivenType(string type)
        {
            List<Product> removable = inVendingMachine.Where(x => x.Type == type).ToList();
            foreach(var product in removable)
            {
                RemoveProduct(product.Name);
            }
        }
        
        public string GetInfoAboutAllProductsByType()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var types in inVendingMachine.Select(x => x.Type).Distinct())
            {
                counts.Add(types, inVendingMachine.Where(y => y.Type == types).ToList().Count);
            }
            foreach(var key in counts.OrderBy(x => x.Value))
            {
                Console.WriteLine($"Type: {key.Key} has total of - {key.Value} products.");
            }
            return "";
        }
    }
}
