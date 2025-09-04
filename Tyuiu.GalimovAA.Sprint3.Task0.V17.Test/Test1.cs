using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint3.Task0.V17.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = ds.GetSumSeries(1, 10);
            double wait = -0.689;

            Assert.AreEqual(wait, value);
        }
    }
}