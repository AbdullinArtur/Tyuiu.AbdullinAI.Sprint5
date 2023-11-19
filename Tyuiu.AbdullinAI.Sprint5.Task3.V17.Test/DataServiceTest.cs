using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint5.Task3.V17.Lib;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\hahaha\source\repos\Tyuiu.AbdullinAI.Sprint5\Tyuiu.AbdullinAI.Sprint5.Task3.V17\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);

            bool wait = true;
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(wait, fileExists);
            
        }
    }
}
