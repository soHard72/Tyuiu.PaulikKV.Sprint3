using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint3.Task7.V17.Lib;

namespace Tyuiu.PaulikKV.Sprint3.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 0.96;
            valueWaitArray[1] = 0.96;
            valueWaitArray[2] = 0.96;
            valueWaitArray[3] = 0.96;
            valueWaitArray[4] = 0.96;
            valueWaitArray[5] = 0.96;
            valueWaitArray[6] = 0.96;
            valueWaitArray[7] = 0.96;
            valueWaitArray[8] = 0.96;
            valueWaitArray[9] = 0.96;
            valueWaitArray[10] = 0.96;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
