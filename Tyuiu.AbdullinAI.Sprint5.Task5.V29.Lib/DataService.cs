using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbdullinAI.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {

        public double LoadFromDataFile(string path)
        {
            double[] res = new double[20];
            int i = 0;
            double m = 100000000;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while (((line = reader.ReadLine()) != null))
                {
                    res[i] = Convert.ToDouble(line);
                    i++;
                }
            }

            for (int b = 0; b < res.Length; b++)
            {
                if ((((res[b] > -100) && (res[b] <= -10)) || ((res[b] >= 10) && (res[b] < 100))) && (res[b] < m))
                {
                    m = res[b];
                }
            }
            return m;
        }
    }
}
