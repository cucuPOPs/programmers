using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _104
{
    class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            int[] array = arr.Where(x => x % divisor == 0).OrderBy(x => x).ToArray();

            if (array.Length == 0)
                return new int[] { -1 };

            return array;
        }
    }
}
