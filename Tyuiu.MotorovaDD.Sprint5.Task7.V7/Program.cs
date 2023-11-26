using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint5.Task7.V7.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task7.V7
{
    class Program
    {
        private static object ds;

        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Моторова Д.Д. | СМАРТб-23-1";

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                             *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                                      *");
            Console.WriteLine("* Таск #7                                                                               *");
            Console.WriteLine("* Вариaнт #7                                                                            *");
            Console.WriteLine("* Выполнила: Моторова Дана Дмитриевна | СМАРТб-23-1                                     *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                              *");
            Console.WriteLine("* Дан файл InPutDataFileTask7V7.txt Создать папку в ручную и скопировать                *");
            Console.WriteLine("* в неё файл в котором есть набор символьных данных. Удалить все заглавные русские      *");
            Console.WriteLine("* буквы из файла. Полученный результат сохранить в файл OutPutDataFileTask7V7.txt.      *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                      *");
            Console.WriteLine("*****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V7.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТAТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");

            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V7.txt";

            Console.WriteLine("Результат сохранён в файл: " + pathSaveFile);


       
            Console.ReadKey();

        }
    }
}
