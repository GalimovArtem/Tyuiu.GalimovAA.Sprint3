using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalimovAA.Sprint3.Task5.V15.Lib
{
    public class DataService : ISprint3Task5V15
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumTotal = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                double sumInner = 0;

                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double term = Math.Sin(x) + (Math.Pow(k, 2) / 2);
                    sumInner += term;
                }

                sumTotal += sumInner;
            }

            return Math.Round(sumTotal, 3);
        }
    }
}
