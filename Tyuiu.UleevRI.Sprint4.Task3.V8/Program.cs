﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint4.Task3.V8.Lib;

namespace Tyuiu.UleevRI.Sprint4.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5]
            {
                { 4, 8, 3, 4, 8 },
                { 5, 3, 5, 7, 8 },
                { 3, 7, 2, 7, 7 },
                { 5, 2, 4, 6, 4 },
                { 4, 4, 6, 7, 2 }
            };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Улеев Р.И. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант 8                                                               *");
            Console.WriteLine("* Выполнил: Улеев Роман Игоревич | ИИПБ-23-3                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Найдите минимальный      *");
            Console.WriteLine("* элемент в четвертом столбце массива.                                    *");
            Console.WriteLine("* 4, 8, 3, 4, 8,                                                          *");
            Console.WriteLine("* 5, 3, 5, 7, 8,                                                          *");
            Console.WriteLine("* 3, 7, 2, 7, 7,                                                          *");
            Console.WriteLine("* 5, 2, 4, 6, 4,                                                          *");
            Console.WriteLine("* 4, 4, 6, 7, 2,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Минимальный элемент в четвертом столбце = " + res);
            Console.ReadKey();
        }
    }
}
