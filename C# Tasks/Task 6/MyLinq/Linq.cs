using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinq
{
    public class Linq
    {
        public static int Maks(int [] array)
        {
            int maks = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maks) maks = array[i];
            }

            return maks;
        }
        public static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
            }

            return min;
        }
        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
