using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_sort
{
    public class GetMaxValue
    {
        public static int GetMaxNum(int[] array)
        {
            var maxNum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < array[i])
                    maxNum = array[i];
            }
            return maxNum;
        }
    }
}
