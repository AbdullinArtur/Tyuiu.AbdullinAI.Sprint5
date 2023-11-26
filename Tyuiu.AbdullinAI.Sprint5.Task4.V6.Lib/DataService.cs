using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbdullinAI.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double x = Convert.ToDouble(str); 
            double res = (1 / Math.Cos(x)) + 2.2 * x * x;

            return res;
        }
    }
}
