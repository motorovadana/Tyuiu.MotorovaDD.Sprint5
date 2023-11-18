using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.MotorovaDD.Sprint5.Task0.V14.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\моторовадана\sourse\repos\Tyuiu.MotorovaDD.Sprint5\Tyuiu.MotorovaDD.Sprint5.Task0.V14\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileI = new FileInfo(path);
            bool fileE = fileI.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileE);
        }
    }
}
