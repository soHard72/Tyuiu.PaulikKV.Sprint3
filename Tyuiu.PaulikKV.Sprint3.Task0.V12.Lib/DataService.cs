using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PaulikKV.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            int k;
            for (k = startValue; k <= stopValue; k++)
            {
                MultiplySeries = MultiplySeries * (1 + (1 / (k + 1)));
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
