using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"\DataSprint5\InPutDataFileTask5V29.txt";

            FileInfo finf = new FileInfo(path);
            bool fex = finf.Exists;
            Assert.AreEqual(true, fex);
        }
    }
}
