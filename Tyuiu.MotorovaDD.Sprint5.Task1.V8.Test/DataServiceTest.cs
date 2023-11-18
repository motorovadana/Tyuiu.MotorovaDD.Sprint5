using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MotorovaDD.Sprint5.Task1.V8.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void NotImplementedException()
        {
            string path = @"C:\Users\моторовадана\source\repos\Tyuiu.MotorovaDD.Sprint5\Tyuiu.MotorovaDD/Sprint5.Task0.V8\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
