using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double a;
            string strA;

            for (int x = startValue; x <= stopValue; x++)
            {
                a = Math.Round( ((2 * x + 6) / (Math.Cos(x) + x)) - 3, 2);

                if (Math.Cos(x) + x == 0)
                {
                    File.AppendAllText(path, "0" + Environment.NewLine); ;
                }
                else
                {
                    strA = a.ToString();

                    if (x != stopValue)
                    {
                        File.AppendAllText(path, strA + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, strA);
                    }
                }                
            }
            return path;
        }
    }
}
