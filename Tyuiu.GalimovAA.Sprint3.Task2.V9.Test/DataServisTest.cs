using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint3.Task2.V9.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            double result = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.041;

            Assert.AreEqual(wait, result);
        }
    }
}