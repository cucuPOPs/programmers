using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _111
{

    class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) answer += i;
            }

            return answer;
        }

        public void PrintSample(string[] args)
        {
            CompareResult(28, solution(12));
            CompareResult(6, solution(5));
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
                Console.WriteLine("answer : " + answer);
                Console.WriteLine("result: " + result);
            }
        }
    }
}