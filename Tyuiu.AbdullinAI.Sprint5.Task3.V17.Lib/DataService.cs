using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AbdullinAI.Sprint5.Task3.V17.Lib
{
    public class DataService : ISprint5Task3V17
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double z = Math.Round(2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x - 1.4 * x + 4.1,3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
