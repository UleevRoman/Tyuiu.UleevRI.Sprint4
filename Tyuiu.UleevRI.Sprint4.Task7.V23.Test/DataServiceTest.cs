﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint4.Task7.V23.Lib;

namespace Tyuiu.UleevRI.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 4;
            int columns = 3;
            int[,] num = new int[rows, columns];
            string str = "678135972584";
            int res = ds.Calculate(rows, columns, str);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
