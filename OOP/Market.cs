using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Product
    {
        public string Name { get; private set; }
        public string Barcode { get; private set; }
        public double Value { get; set; }
        public double Quantity { get; set; }

        public Product(string name, string barcode)
        {
            this.Name = name;
            this.Barcode = barcode;
        }

    }
    static class Market
    {
        public static List<Product> products = new List<Product>();   
        
        public static Product Add(string barcode, string name, double value, double quantity)
        {
            products.Add(new Product(name, barcode) { Quantity = quantity, Value = value });
            return products.Last();
        }

        public static Product Update(string barcode, double newQuantity)
        {
            if(!products.Exists(x => x.Barcode == barcode))
            {
                Console.WriteLine("Please add your product first!");
                return null;
            }
            int currProductIndex = products.IndexOf(products.Find(x => x.Barcode == barcode));
            products[currProductIndex].Quantity = newQuantity;
            return products[currProductIndex];
        }

        public static void Sell(string barcode, double quantity)
        {
            if (products.Exists(x => x.Barcode == barcode))
            {

                Product toSell = products.Find(x => x.Barcode == barcode);
                if (toSell.Quantity >= quantity)
                {
                    Market.Update(toSell.Barcode, toSell.Quantity - quantity);
                    return;
                }
                else
                {
                    Console.WriteLine("Not enough quantity");
                }
            }
            else
            {
                throw new Exception("No such a product");
            }
        }

        public static List<Product> Accessible()
        {
            return products.Where(x => x.Quantity > 0).ToList();
        }

        public static List<Product> Unaccessible()
        {
            return products.Except(Market.Accessible()).ToList();
        }

        public static List<Product> SortByDecending()
        {
            return products.OrderByDescending(x => x.Quantity).ToList();
        }

        public static double Calculate()
        {
             return products.Select(x => x.Quantity).
                Zip(products.Select(y => y.Value), (a, b) => a * b).Sum();
        }
    }
}
