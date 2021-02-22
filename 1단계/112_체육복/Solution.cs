using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _112
{

    class Solution
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < n; i++) answer.Add(1);
            for (int i = 0; i < reserve.Length; i++) answer[reserve[i] - 1]++;
            for (int i = 0; i < lost.Length; i++) answer[lost[i] - 1]--;

            for (int i = 0; i < n; i++)
            {
                if (answer[i] == 0)
                {
                    if (i - 1 >= 0 && answer[i - 1] == 2)
                    {
                        answer[i - 1] = 1;
                        answer[i] = 1;
                        continue;
                    }
                    if (i + 1 < answer.Count && answer[i + 1] == 2)
                    {
                        answer[i + 1] = 1;
                        answer[i] = 1;
                        continue;
                    }
                }
            }
            int count = answer.Where(x => x >= 1).Count();
            return count;
        }

        public void PrintSample(string[] args)
        {
            CompareResult(5, solution(5, new int[] { 2, 4 }, new int[] { 1, 3, 5 }));
            CompareResult(4, solution(5, new int[] { 2, 4 }, new int[] { 3 }));
            CompareResult(2, solution(3, new int[] { 3 }, new int[] { 1 }));
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