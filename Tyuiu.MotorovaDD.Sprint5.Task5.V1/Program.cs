using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Tyuiu.MotorovaDD.Sprint5.Task5.V1.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Моторова Д. Д. | СМАРТб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                           *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #1                                                                        *");
            Console.WriteLine("* Выполнила: Моторова Дана Дмитриевна | СМАРТб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Найти сумму всех чисел с признаками деления на 2                                  *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V1.txt";

            Console.WriteLine("Данные находится в файле: " + path);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
