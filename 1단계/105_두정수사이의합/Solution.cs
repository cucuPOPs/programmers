using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _105
{
    class Solution
    {
        public long solution(int a, int b)
        {
            if (a == b) return a;
            int min = a < b ? a : b;
            int max = a < b ? b : a;

            long sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;
            }

            return sum;
        }

        public void PrintSample()
        {
            CompareResult(12, solution(3, 5));
        }

        void CompareResult(long answer, long result)
        {
            if (answer.Equals(result))
            {
                Console.WriteLine("통과!");
            }
            else
            {
                Console.WriteLine("에러!");
                Console.Write("answer : " + answer);
                Console.Write("result: " + result);
            }
        }
    }
}