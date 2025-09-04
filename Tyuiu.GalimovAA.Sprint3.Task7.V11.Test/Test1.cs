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
                -14.71, -10.71, -6.96, -3.65, -1.04, 0, -7.46, -10.71, -13.29, -15.32, -16.96
            };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();

            int startValue = 0;
            int stopValue = 2;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Проверяем, что при x=1 (деление на ноль) возвращается 0
            Assert.AreEqual(0, res[1]);
        }
    }
}