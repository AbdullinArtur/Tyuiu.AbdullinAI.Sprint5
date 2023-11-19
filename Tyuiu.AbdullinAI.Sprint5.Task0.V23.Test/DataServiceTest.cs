using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AbdullinAI.Sprint5.Task0.V23.Lib;

namespace Tyuiu.AbdullinAI.Sprint5.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string pathh = @"C:\Users\hahaha\source\repos\Tyuiu.AbdullinAI.Sprint5\Tyuiu.AbdullinAI.Sprint5.Task0.V23\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(pathh);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
