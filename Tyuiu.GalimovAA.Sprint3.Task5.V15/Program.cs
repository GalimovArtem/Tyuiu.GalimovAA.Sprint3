using System;
using Tyuiu.GalimovAA.Sprint3.Task5.V15.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            Console.Title = "Спринт #3 | Выполнил: Галимов А.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму двойного ряда:              *");
            Console.WriteLine("* y = Σ(i=1 to 3) Σ(k=1 to 10) [sin(x) + k²/2] при x = 5                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"startValue1 = {startValue1}");
            Console.WriteLine($"stopValue1 = {stopValue1}");
            Console.WriteLine($"startValue2 = {startValue2}");
            Console.WriteLine($"stopValue2 = {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"y = {result}");

            Console.ReadKey();
        }
    }
}