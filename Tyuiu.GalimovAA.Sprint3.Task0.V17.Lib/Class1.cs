using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalimovAA.Sprint3.Task0.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sum += Math.Cos(i) * 0.5;
            }
            return Math.Round(sum, 3);
        }
    }
}
