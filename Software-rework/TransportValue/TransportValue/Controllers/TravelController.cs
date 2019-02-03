using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportValue.Models;
using TransportValue.Views;

namespace TransportValue.Controllers
{
    class TravelController
    {
        private Display display;
        private Travels travels;

        public TravelController()
        {
            display = new Display();
            travels = new Travels(display.Distance, display.Time);
            Console.WriteLine(travels.Distance);
            Console.WriteLine(travels.Time);
            display.MinCost = travels.CalculateMinCost();
            display.Output();
        }
    }
}
