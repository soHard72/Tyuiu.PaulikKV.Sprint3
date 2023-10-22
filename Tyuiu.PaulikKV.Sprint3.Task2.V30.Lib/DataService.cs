using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PaulikKV.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MultSeries = 1;
            do
            {
                MultSeries = MultSeries * (value * value * startValue) + 2;
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(MultSeries, 3);
        }
    }
}
