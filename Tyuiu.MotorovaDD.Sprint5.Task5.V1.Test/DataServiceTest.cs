using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.MotorovaDD.Sprint5.Task5.V1.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V1.txt";
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
