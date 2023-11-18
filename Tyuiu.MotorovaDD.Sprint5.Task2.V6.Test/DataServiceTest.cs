using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.MotorovaDD.Sprint5.Task2.V6.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\моторовадана\source\repos\Tyuiu.MotorovaDD.Sprint5\Tyuiu.MotorovaDD/Sprint5.Task2.V6\bin\Debug\OutPutFileTask2.csv";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            bool wait = false;
            Assert.AreEqual(wait, exists);
        }
    }
}
