using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadingHomework
{
    public class Generator
    {
        public long[] GetGeneratedArray(int arrayLenth)
        {
            long[] generatedArray = new long[arrayLenth];

            for (int i = 0; i < generatedArray.Length; i++)
            {
                generatedArray[i] = (long)i;
            }

            return generatedArray;
        }

        public List<long> GetParallelGenerateArray(int listLenth)
        {
            List<long> generatedList = new List<long>();
            var locker = new object();

            for (int i = 0; i < 10; i++)
            {

                ThreadPool.QueueUserWorkItem(_ =>
                {
                    lock (locker)
                    {
                        generatedList.AddRange(GetGeneratedArray(listLenth / 10));
                    }
                });
            }

            Thread.Sleep(500);

            lock (locker)
            {
                return generatedList;
            }
        }
    }
}
