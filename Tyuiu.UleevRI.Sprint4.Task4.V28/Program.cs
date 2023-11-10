using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint4.Task4.V28.Lib;

namespace Tyuiu.UleevRI.Sprint4.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Улеев Р.И. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант 28                                                              *");
            Console.WriteLine("* Выполнил: Улеев Роман Игоревич | ИИПБ-23-3                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 5. Заменить четные элементы *");
            Console.WriteLine("* массива на 1.                                                           *");
            Console.WriteLine("* 3, 3, 1, 1, 4,                                                          *");
            Console.WriteLine("* 2, 4, 2, 1, 5,                                                          *");
            Console.WriteLine("* 2, 2, 2, 2, 2,                                                          *");
            Console.WriteLine("* 1, 5, 4, 5, 4,                                                          *");
            Console.WriteLine("* 1, 2, 3, 2, 4,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int m = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((matrix[i, j] < 1) || (matrix[i, j] > 5)) m += 1 ;
                }
            }
            if (m > 0)
            {
                Console.WriteLine(0);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nМассив: ");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                int[,] res = ds.Calculate(matrix);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{res[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
