using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalimovAA.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль (знаменатель x-1 = 0 при x=1)
                if (x == 1)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = x;
                    double denominator = x - 1;
                    double fraction = numerator / denominator;

                    valueArray[count] = Math.Cos(x) + fraction - 4 * x;
                    valueArray[count] = Math.Round(valueArray[count], 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}