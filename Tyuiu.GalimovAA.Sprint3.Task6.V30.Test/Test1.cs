using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint3.Task6.V30.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;
            int wait = 35;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, result);
        }
    }
}