using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _102
{
    class Solution
    {
        public string solution(string s)
        {
            char[] charArray = s.ToCharArray();
            int idx = charArray.Length / 2;

            if (charArray.Length % 2 == 0)
            {
                char[] ch2 = new char[2];
                ch2[1] = charArray[idx];
                ch2[0] = charArray[idx - 1];
                return new string(ch2);
            }
            else
            {
                char ch1 = charArray[idx];
                return ch1.ToString();
            }
        }

        public void PrintSample()
        {
            CompareResult("c", solution("abcde"));
        }

        static void CompareResult(string answer, string result)
        {
            if (answer.Equals(result))
            {
                Console.WriteLine("통과!");
            }
            else
            {
                Console.WriteLine("에러!");
                Console.Write("answer : " + answer);
                Console.Write("input: " + result);
            }
        }
    }
}
