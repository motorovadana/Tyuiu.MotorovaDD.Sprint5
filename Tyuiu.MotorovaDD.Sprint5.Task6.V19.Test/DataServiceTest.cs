using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MotorovaDD.Sprint5.Task6.V19.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 0;
            Assert.AreEqual(3,res);

        }
    }
}
