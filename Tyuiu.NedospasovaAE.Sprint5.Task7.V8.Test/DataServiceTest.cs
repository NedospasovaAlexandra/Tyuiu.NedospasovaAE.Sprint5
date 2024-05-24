﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.NedospasovaAE.Sprint5.Task7.V8.Lib;

namespace Tyuiu.NedospasovaAE.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint5\Tyuiu.NedospasovaAE.Sprint5.Task7.V8\bin\Debug\InPutDataFileTask7V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
