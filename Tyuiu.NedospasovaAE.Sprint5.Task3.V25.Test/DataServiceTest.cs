using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.NedospasovaAE.Sprint5.Task3.V25.Lib;

namespace Tyuiu.NedospasovaAE.Sprint5.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint5\Tyuiu.NedospasovaAE.Sprint5.Task3.V25.Lib\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
