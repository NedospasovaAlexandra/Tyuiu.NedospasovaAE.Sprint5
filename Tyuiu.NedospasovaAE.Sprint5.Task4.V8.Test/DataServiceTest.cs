using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint5.Task4.V8.Lib;
using System.IO;

namespace Tyuiu.NedospasovaAE.Sprint5.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint5\Tyuiu.NedospasovaAE.Sprint5.Task4.V8\bin\Debug\InPutDataFileTask4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
