using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint5.Task5.V29.Lib;

namespace Tyuiu.AbdullinAI.Sprint5.Task5.V29
{
    internal class Program
    {
        private static bool x;

        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"\DataSprint5\InPutDataFileTask5V29.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Наименбшее двузначное число = " + res);



            /*double[] res = new double[20];
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
                if ( (((res[b] > -100) && (res[b] <= -10)) || ((res[b] >= 10) && (res[b] < 100)) ) && (res[b] < m))
                {
                    m = res[b];
                }
            }                                                                                                    

           for (int a = 0; a < res.Length; a++)
           {
                Console.Write($"{res[a]} ");
           } 
             */
            
           
           
                     
            Console.ReadKey();
        }
    }
}
