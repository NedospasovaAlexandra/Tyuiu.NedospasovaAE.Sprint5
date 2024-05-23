using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.NedospasovaAE.Sprint5.Task6.V13.Lib;

namespace Tyuiu.NedospasovaAE.Sprint5.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint5\Tyuiu.NedospasovaAE.Sprint5.Task6.V13\bin\Debug\InPutDataFileTask6V13.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint5\Tyuiu.NedospasovaAE.Sprint5.Task6.V13\bin\Debug\InPutDataFileTask6V13.txt";

            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
