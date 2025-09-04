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

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;
                if (x == 1)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double term1 = Math.Cos(x);
                    double term2 = x / (double)(x - 1);
                    double term3 = 4 * x;

                    valueArray[i] = term1 + term2 - term3;
                    valueArray[i] = Math.Round(valueArray[i], 2);
                }
            }

            return valueArray;
        }
    }
}