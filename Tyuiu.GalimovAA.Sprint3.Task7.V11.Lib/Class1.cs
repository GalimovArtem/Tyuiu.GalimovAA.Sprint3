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
                double x = startValue + i; 
                if (Math.Abs(x - 2) < double.Epsilon)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double cosX = Math.Cos(x);
                    double sinX = Math.Sin(x);
                    double denominator = x - 2;
                    double functionValue = cosX + (sinX / denominator) - 4 * x;
                    valueArray[i] = Math.Round(functionValue, 2);
                }
            }

            return valueArray;
        }
    }
}