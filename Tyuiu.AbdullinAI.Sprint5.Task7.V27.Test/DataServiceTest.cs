using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AbdullinAI.Sprint5.Task7.V27.Lib;

namespace Tyuiu.AbdullinAI.Sprint5.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"\DataSprint5\OutPutDataFileTask7V27.txt";
            FileInfo fileinf = new FileInfo(path);
            bool fex = fileinf.Exists;
            Assert.AreEqual(true, fex);
        }
    }
}
