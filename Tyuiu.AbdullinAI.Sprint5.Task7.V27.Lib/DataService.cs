using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Tyuiu.AbdullinAI.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        

        public string LoadDataAndSave(string path)
        {
            string newpath = $@"\DataSprint5\OutPutDataFileTask7V27.txt";
            
            FileInfo fileInfo = new FileInfo(newpath);
            bool fex = File.Exists(newpath);
            if (fex)
            {
                File.Delete(newpath);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    foreach (char c in line)
                    {
                        if (c != ' ')
                        {
                            strLine += c;
                        }
                    }

                    File.AppendAllText(newpath, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return newpath;
        }   
    }
}
