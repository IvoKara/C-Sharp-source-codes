using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMVC.Views;
using ConsoleMVC.Models;

namespace ConsoleMVC.Conroller
{
    class TipCalculatorController
    {
        private Tips tip;
        private Display display;

        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tips(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip(); 
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }
    }
}
