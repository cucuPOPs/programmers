using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _110
{
    class Solution
    {
        public string solution(string s, int n)
        {
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLower(charArray[i]))
                {
                    charArray[i] = (char)(((charArray[i] + n) % 'a' % 26) + 'a');
                }
                else if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = (char)(((charArray[i] + n) % 'A' % 26) + 'A');
                }
            }

            return new string(charArray);
        }

        public void PrintSample(string[] args)
        {
            CompareResult("BC", solution("AB", 1));
            CompareResult("a", solution("z", 1));
            CompareResult("e F d", solution("a B z", 4));
        }

        void CompareResult(string answer, string result)
        {
            if (answer.Equals(result))
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