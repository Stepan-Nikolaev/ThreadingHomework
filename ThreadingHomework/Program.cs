using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadingHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var generator = new Generator();

            //Последовательное вычисление массива на 10 000 000 элементов

            var array10MElevents = generator.GetGeneratedArray(10000000);
            int array10MEleventsArithmeticMean = calculator.GetArrayArithmeticMean(array10MElevents);

            //Последовательное вычисление массива на 100 000 000 элементов

            var array100MElevents = generator.GetGeneratedArray(10000000);
            int array100MEleventsArithmeticMean = calculator.GetArrayArithmeticMean(array10MElevents);

            //Параллельное вычисление массива на 10 000 000 элементов

            List<long> array10MEleventsParallel = generator.GetParallelGenerateArray(10000000);
            int array10MEleventsParallelArithmeticMean = calculator.GetArrayArithmeticMean(array10MEleventsParallel);

            //Параллельное вычисление массива на 100 000 000 элементов

            List<long> array100MEleventsParallel = generator.GetParallelGenerateArray(100000000);
            int array100MEleventsParallelArithmeticMean = calculator.GetArrayArithmeticMean(array100MEleventsParallel);

        }
    }
}
