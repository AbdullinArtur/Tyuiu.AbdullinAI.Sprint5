using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AbdullinAI.Sprint5.Task6.V23.Lib;

namespace Tyuiu.AbdullinAI.Sprint5.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V23.txt";
            FileInfo finf = new FileInfo(path);
            bool fex = finf.Exists;
            Assert.AreEqual(true, fex);
        }

        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V23.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}
