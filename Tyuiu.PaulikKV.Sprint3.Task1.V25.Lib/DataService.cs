using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PaulikKV.Sprint3.Task1.V25.Lib
{
    public class DataService : ISprint3Task1V25
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            while (startValue <= stopValue)
            {
                MultiplySeries = MultiplySeries * ((Math.Pow(value, startValue) - (1 / 4)) * Math.Cos(5));
                startValue++;
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
