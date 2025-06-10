using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_sort
{
    public class Radixsort
    {
        public static long TotalIterations { get; private set; }
        public static int[] RadixSort(int[] array)
        {
            TotalIterations = 0;
            var maxValue = GetMaxValue.GetMaxNum(array);

            for (int category = 1; maxValue / category > 0; category *= 10)
            {
                CoutingSort.DoCoutingSort(array, category);
                TotalIterations++;
                TotalIterations += CoutingSort.IterationsCount;
            }

            return array;
        }
    }
}
