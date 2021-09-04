using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadingHomework
{
    public class Calculator
    {
        public int GetArrayArithmeticMean(long[] array)
        {
            long sumValuesArray = 0;

            foreach (var item in array)
            {
                sumValuesArray += item;
            }

            long arithmeticMean = sumValuesArray / array.Length;

            return (int)arithmeticMean;
        }

        public int GetArrayArithmeticMean(List<long> array)
        {
            long sumValuesArray = 0;

            foreach (var item in array)
            {
                sumValuesArray += item;
            }

            long arithmeticMean = sumValuesArray / array.Count;

            return (int)arithmeticMean;
        }
    }
}
