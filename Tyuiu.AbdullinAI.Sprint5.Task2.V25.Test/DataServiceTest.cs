using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint5.Task2.V25.Lib;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint5.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\hahaha\source\repos\Tyuiu.AbdullinAI.Sprint5\Tyuiu.AbdullinAI.Sprint5.Task2.V25\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinf = new FileInfo(path);
            bool fileExists = fileinf.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
