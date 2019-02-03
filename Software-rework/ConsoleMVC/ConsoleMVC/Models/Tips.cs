    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    public class Tips
    {
        private double amount;
        private double percent;

        public double Amount
        { get { return this.amount; } set { this.amount = value; } }
        public double Percent 
        {
            get { return this.percent;  }
            set
            {
                if (value > 1)
                    this.percent = value / 100.00;

                else
                    this.percent = value;
            }
        }

        public Tips(double amount, double percent)
        {
            Amount = amount;
            Percent = percent; 
        }

        public Tips() : this(0, 0) { }

        public double CalculateTip()
        {
            return Amount * Percent;
        }

        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }
    }
}
