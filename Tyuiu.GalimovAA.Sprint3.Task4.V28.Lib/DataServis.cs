using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalimovAA.Sprint3.Task4.V28.Lib
{
    public class DataService : ISprint3Task4V28
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue; // Пропускаем x = 0
                }

                double y = (Math.Cos(x) + Math.Sin(x)) / x;
                sum += y;
            }

            return Math.Round(sum, 3);
        }
    }
}