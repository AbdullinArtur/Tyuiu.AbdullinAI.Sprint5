using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint5.Task1.V26.Lib;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint5.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string pathh = @"C:\Users\hahaha\source\repos\Tyuiu.AbdullinAI.Sprint5\Tyuiu.AbdullinAI.Sprint5.Task1.V26\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(pathh);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }   
}
