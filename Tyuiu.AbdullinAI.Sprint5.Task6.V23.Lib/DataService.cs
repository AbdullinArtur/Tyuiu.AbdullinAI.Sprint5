using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Runtime.CompilerServices;

namespace Tyuiu.AbdullinAI.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            int k = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '-')
                        {
                            k++;
                        }
                    }
                }
            }
            return k;
        }
    }
}
