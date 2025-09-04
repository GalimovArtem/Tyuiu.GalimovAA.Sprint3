using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalimovAA.Sprint3.Task2.V9.Lib
{
    public class DataService : ISprint3Task2V9
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                double term = Math.Pow(1.0 / Math.Pow(value, k), 2);
                sum += term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
