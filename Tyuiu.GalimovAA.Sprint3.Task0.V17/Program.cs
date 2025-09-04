using System;
using Tyuiu.GalimovAA.Sprint3.Task0.V17.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Галимов А.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
            Console.WriteLine("* по формуле S = Σ(cos i * 1/2) от i=1 до i=10                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Начало цикла: 1                                                         *");
            Console.WriteLine("* Конец цикла: 10                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(1, 10);
            Console.WriteLine($"* Сумма ряда S = Σ(cos i * 1/2) от i=1 до i=10: {result} *");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}