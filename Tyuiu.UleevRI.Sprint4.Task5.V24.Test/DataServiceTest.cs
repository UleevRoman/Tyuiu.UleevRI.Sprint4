using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint4.Task5.V24.Lib;

namespace Tyuiu.UleevRI.Sprint4.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] num = new int[5, 5]
            {
                { -8, 9, -3, 4, 8 },
                { -5, 3, 5, 7, 8 },
                { -3, 7, -2, 7, 7 },
                { -5, 2, -4, 6, 4 },
                { -4, 4, 6, 7, 2 }
            };
            int res = ds.Calculate(num);
            int wait = 17;
            Assert.AreEqual(wait, res);
        }
    }
}
