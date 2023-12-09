using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NikolaichukVS.Sprint6.Task7.V5.Lib;
using System.IO;

namespace Tyuiu.NikolaichukVS.Sprint6.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutFileTask7V5.csv.";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
