using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStatsKata
{
    public class CalcStats
    {
        public int GetMinimum(int[] numbers)
        {
            return numbers.Min();
        }

        public int GetMaximum(int[] numbers)
        {
            return numbers.Max();
        }

        public int GetCount(int[] numbers)
        {
            return numbers.Count();
        }

        public double GetAverage(int[] numbers)
        {
            return numbers.Average();
        }
    }
}
