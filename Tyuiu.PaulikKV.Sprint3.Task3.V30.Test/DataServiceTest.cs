using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint3.Task3.V30.Lib;

namespace Tyuiu.PaulikKV.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            string value = "fyyklbtyn ygrc vfyyyyh";
            char chr = 'y';
            double res = ds.GetMaxCharCount(value, chr);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
