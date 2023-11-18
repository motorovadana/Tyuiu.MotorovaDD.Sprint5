using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint5.Task2.V6.Lib;

namespace Tyuiu.MotorovaDD.Sprint5.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Моторова Д. Д. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Моторова Дана Дмитриевна | СМАРТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дан двумерный целочисленный массив 3 на3 элементов,заполненный значениями*");
            Console.WriteLine("*с клавиатуры. Заменить положительные элементы массива на 1, отрицательные*");
            Console.WriteLine("*на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* -2; 1; 8                                                                *");
            Console.WriteLine("* -4; -7; 8                                                               *");
            Console.WriteLine("* 6; 5; 5                                                                 *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[3, 3] { { -2, 1, 8 }, { -4, -7, 8 }, { 6, 5, 5 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();


        }
    }
}
