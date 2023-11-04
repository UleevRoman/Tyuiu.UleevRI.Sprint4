using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint4.Task2.V12.Lib;

namespace Tyuiu.UleevRI.Sprint4.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5 };
            int res = ds.Calculate(array);
            int wait = 52;
            Assert.AreEqual(wait, res);
        }
    }
}
