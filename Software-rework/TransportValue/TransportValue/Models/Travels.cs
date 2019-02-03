using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportValue.Models
{
    public class Travels
    {    
        public int Distance { get; set; }
        public string Time { get; set; }

        public Travels(int distance, string time)
        {
            Distance = distance;
            Time = time;
        }

        private double CalcualteVehicleCost(string vehicle)
        {
            double tariff = 10;
            switch (vehicle)
            {
                case "taxi":
                    switch (Time)
                    {
                        case "day": tariff = 0.79; break;
                        case "night": tariff = 0.90; break;
                        default: throw new ArgumentException("Time must be 'day' or 'night'"); break;
                    } break;               
                case "bus": if(Distance >= 20) tariff = 0.09; break;
                case "train": if(Distance >= 100) tariff = 0.06; break;
            } 
            return  (vehicle == "taxi") ? Distance * tariff + 0.7 : Distance * tariff;
        }

        public double CalculateMinCost()
        {
            return new List<double>() { CalcualteVehicleCost("taxi"), CalcualteVehicleCost("bus"), CalcualteVehicleCost("train")}.Min();
        }
    }
}
