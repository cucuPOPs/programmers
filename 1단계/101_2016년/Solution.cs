using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _101
{
    class Solution
    {
        public string solution(int a, int b)
        {
            //1월 1일 = 금요일.
            List<string> week = new List<string>() { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
            List<int> month = new List<int>() { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int sum = b - 1;
            if (a > 1) sum += month.Take(a - 1).Sum();
            return week[sum % week.Count];
        }
        public void PrintSample()
        {
            CompareResult("TUE", solution(5, 24));
        }

        void CompareResult(object answer, object result)
        {
            if (answer.Equals(result))
            {
                Console.WriteLine("통과!");
            }
            else
            {
                Console.WriteLine("에러!");
                Console.WriteLine("answer : " + answer.ToString());
                Console.WriteLine("result: " + result.ToString());
            }
        }
    }
}
