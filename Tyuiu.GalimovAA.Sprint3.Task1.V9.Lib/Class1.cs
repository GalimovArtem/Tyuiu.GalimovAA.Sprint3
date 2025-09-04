using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalimovAA.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                double denominator = Math.Cos(value) + Math.Pow(value, k);
                if (Math.Abs(denominator) < 0.0001) // Проверка деления на ноль
                {
                    throw new ArgumentException("Знаменатель близок к нулю, деление невозможно");
                }

                double term = 300.0 / denominator;
                product *= Math.Pow(term, k);
                k++;
            }

            return Math.Round(product, 3);
        }
    }
}