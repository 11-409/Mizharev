using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_sort
{
    public class CoutingSort
    {
        public static long IterationsCount { get; private set; }
        public static void DoCoutingSort(int[] array, int category)
        {
            IterationsCount = 0;
            var outputArr = new int[array.Length];
            var occurences = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                occurences[(array[i] / category) % 10]++;
                IterationsCount++;
            }
            for (int i = 1; i < 10; i++)
            {
                occurences[i] += occurences[i - 1];
                IterationsCount++;
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                outputArr[occurences[(array[i] / category) % 10] - 1] = array[i];
                occurences[(array[i] / category) % 10]--;
                IterationsCount++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = outputArr[i];
                IterationsCount++;
            }
        }
    }
}
