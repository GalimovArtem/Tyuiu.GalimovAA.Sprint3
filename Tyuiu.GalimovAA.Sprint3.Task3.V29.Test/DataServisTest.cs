using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint3.Task3.V29.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();

            string value = "chgr vhhtg hnht";
            char item = 'h';
            string wait = "cgr vtg nt";

            string result = ds.DeleteCharInString(value, item);

            Assert.AreEqual(wait, result);
        }
    }
}