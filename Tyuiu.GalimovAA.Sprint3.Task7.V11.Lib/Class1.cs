using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalimovAA.Sprint3.Task7.V11.Lib
{
    public class DataService : ISprint3Task7V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;

                // Проверка деления на ноль (x - 2 = 0)
                if (x == 2)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double numerator = Math.Sin(x);
                    double denominator = x - 2;

                    // Проверка деления на ноль (на всякий случай)
                    if (Math.Abs(denominator) < double.Epsilon)
                    {
                        valueArray[i] = 0;
                    }
                    else
                    {
                        double functionValue = Math.Cos(x) + (numerator / denominator) - 4 * x;
                        valueArray[i] = Math.Round(functionValue, 2);
                    }
                }
            }

            return valueArray;
        }
    }
}