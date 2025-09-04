using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint3.Task1.V9.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 4;

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1.344; // Ожидаемое значение, рассчитанное вручную

            Assert.AreEqual(wait, result);
        }
    }
}