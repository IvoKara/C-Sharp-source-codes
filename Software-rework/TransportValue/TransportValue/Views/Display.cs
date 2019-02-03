using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportValue.Views
{
    public class Display
    {
        private int distance;
        private string time;
        private double minCost;

        public int Distance => this.distance;
        public string Time => this.time;
        public double MinCost { get => this.minCost; set => this.minCost = value; }

        public Display()
        {
            this.distance = 0;
            this.time = "";
            this.minCost = 0;
            Input();   
        }

        public void Output()
        {
            Console.WriteLine($"Min Cost: {this.minCost:f2}");
        }

        private void Input()
        {
            Console.Write("Distance: ");
            this.distance = int.Parse(Console.ReadLine());
            Console.Write("Time: ");
            this.time = Console.ReadLine();
        }
    }
}
