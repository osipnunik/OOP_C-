using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second.task3
{
    class RandomArrayService
    {
        public int[] Array { get; set; }
        public void CreateRandomArray(int N)
        {
            Array = new int[N];
        }

        internal void FillArray()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Random r = new Random();
                Array[i] = r.Next(-500, 500);             
            }
        }
        public void SortArray()
        {
            for (int j = 0; j < Array.Length; j++)
            {
                for (int i = 0; i < Array.Length - 1; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        int temp = Array[i];
                        Array[i] = Array[i + 1];
                        Array[i + 1] = temp;
                    }
                }
            }
        }
    }
}
