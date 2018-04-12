using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_concept
{
    class DateModifier
    {
        public readonly int dayDifference;
        public DateModifier(int[] firstDate, int[] secondDate)
        {
            DateTime first = new DateTime(firstDate[0],firstDate[1], firstDate[2]);
            DateTime second = new DateTime(secondDate[0], secondDate[1], secondDate[2]);
            dayDifference =  Math.Abs((first - second).Days);
        }
    }
}
