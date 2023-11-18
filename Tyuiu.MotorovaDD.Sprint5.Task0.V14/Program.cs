using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint5.Task0.V14.Lib;


namespace Tyuiu.MotorovaDD.Sprint5.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Моторова Д. Д. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Моторова Дана Дмитриевна | СМАРТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить    *");
            Console.WriteLine("* до трёх знаков после запятой                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("        4 * x^3                                                           *");
            Console.WriteLine("y(x) = ---------                                                          *");
            Console.WriteLine("        x^3 - 1                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

           

            double res2 = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            res2 = Math.Round(res2, 3);
            Console.WriteLine("Ответ = " + res2);
            Console.WriteLine();


            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
