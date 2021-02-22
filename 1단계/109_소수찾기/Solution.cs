using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _109
{

    class Solution
    {
        public int solution(int n)
        {
            int[] arr = new int[n + 2];
            for (int i = 2; i <= n; i++)
            {
                for (int j = i + i; j <= n; j = j + i)
                {
                    arr[j] = 1;
                }
            }

            int cnt = 0;
            for (int i = 2; i <= n; i++)
            {
                if (arr[i] == 0) cnt++;
            }

            return cnt;
        }

        public void PrintSample(string[] args)
        {
            CompareResult(4, solution(10));
            CompareResult(5, solution(5));
        }

        void CompareResult(int answer, int result)
        {
            if (answer.ToString().Equals(result.ToString()))
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