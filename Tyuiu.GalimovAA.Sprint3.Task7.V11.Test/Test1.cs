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
                19.27, 14.28, 9.29, 4.30, -0.69, 0, -10.67, -15.66, -20.65, -25.64, -30.63
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

            Assert.AreEqual(0, res[0]);
        }
    }
}