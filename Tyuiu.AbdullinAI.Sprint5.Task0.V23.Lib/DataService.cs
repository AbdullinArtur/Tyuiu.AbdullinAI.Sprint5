using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbdullinAI.Sprint5.Task0.V23.Lib
{
    public class DataService : ISprint5Task0V23

    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double z = (1 + Math.Pow(x, 3)) / Math.Pow(x, 2);

            z = Math.Round(z, 3);

            File.WriteAllText(path, z.ToString()); // или Convert.ToString(z);
            return path;
        }
    }
}
