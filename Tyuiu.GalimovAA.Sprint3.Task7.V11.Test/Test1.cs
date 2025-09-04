using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint3.Task7.V11.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task7.V11.Test
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
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {
                20.36, 15.42, 10.99, 7.43, 4.33, 1.0, 0.0, -8.87, -13.03, -16.53, -19.6
            };
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();
            int startValue = 2;
            int stopValue = 2;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(0, res[0]);
        }
        [TestMethod]
        public void CheckSingleValue()
        {
            DataService ds = new DataService();
            int startValue = 0;
            int stopValue = 0;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(1.0, res[0]);
        }
    }
}