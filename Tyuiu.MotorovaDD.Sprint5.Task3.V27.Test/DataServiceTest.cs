using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MotorovaDD.Sprint5.Task3.V27.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\моторовадана\sourse\repos\Tyuiu.MotorovaDD.Sprint5\Tyuiu.MotorovaDD.Sprint5.Task3.V27\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }


    }
}
