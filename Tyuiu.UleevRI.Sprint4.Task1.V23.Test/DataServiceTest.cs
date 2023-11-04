using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint4.Task1.V23.Lib;

namespace Tyuiu.UleevRI.Sprint4.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };
            int res = ds.Calculate(array);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}
