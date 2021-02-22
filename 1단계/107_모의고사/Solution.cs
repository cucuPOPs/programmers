using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _107
{

    class Solution
    {
        int[] solution(int[] answers)
        {
            int[] nRules1 = new int[] { 1, 2, 3, 4, 5 };
            int[] nRules2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] nRules3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] nScores = new int[3];

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == nRules1[i % nRules1.Length]) ++nScores[0];
                if (answers[i] == nRules2[i % nRules2.Length]) ++nScores[1];
                if (answers[i] == nRules3[i % nRules3.Length]) ++nScores[2];
            }

            List<int> lastAnswer = new List<int>();
            if (nScores[0] == nScores.Max()) lastAnswer.Add(1);
            if (nScores[1] == nScores.Max()) lastAnswer.Add(2);
            if (nScores[2] == nScores.Max()) lastAnswer.Add(3);

            return lastAnswer.ToArray();
        }

        public void PrintSample()
        {
            CompareResult(new int[] { 1 }, solution(new int[] { 1, 2, 3, 4, 5 }));
            CompareResult(new int[] { 1, 2, 3 }, solution(new int[] { 1, 3, 2, 4, 2 }));
        }

        void ShowArray(int[] array)
        {
            if (array.Length == 0) return;

            Console.Write("{ ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.WriteLine(array[array.Length - 1] + " }");
        }

        void CompareResult(int[] answer, int[] result)
        {
            if (answer.ToString().Equals(result.ToString()))
            {
                Console.WriteLine("통과!");
            }
            else
            {
                Console.WriteLine("에러!");
                Console.Write("answer : ");
                ShowArray(answer);
                Console.Write("input: ");
                ShowArray(result);
            }
        }
    }
}