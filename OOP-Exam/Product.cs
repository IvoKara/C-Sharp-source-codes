using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Product
    {
        private string name;
        private string type;
        private double price;
        static public int OrdersCount = 0;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string name)
        {
            this.name = name;
        }

        public Product(string type, string name, double price) : this(name)
        {
            this.type = type;
            this.price = price;
        }
        public override string ToString()
        {
            return $"Product with type - {this.type} and name - {this.name}";
        }
    }
}
