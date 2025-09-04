using System;
using Tyuiu.GalimovAA.Sprint3.Task2.V9.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Галимов А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет сумму     *");
            Console.WriteLine("* ряда по формуле, при n=5: S = сумма от k=1 до 10 (1/n^k)^2             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine($"Значение n = {value}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine($"Сумма ряда = {result}");
            Console.ReadKey();
        }
    }
}