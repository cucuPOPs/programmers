using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _103
{

    class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int size = commands.GetLength(0);
            List<int> answer = new List<int>();

            for (int i = 0; i < size; i++)
            {
                List<int> temp = new List<int>();
                for (int j = commands[i, 0] - 1; j <= commands[i, 1] - 1; j++)
                    temp.Add(array[j]);

                temp.Sort();
                answer.Add(temp[commands[i, 2] - 1]);
            }

            return answer.ToArray();
        }

        public void PrintSample(string[] args)
        {
            CompareResult(new int[] { 5, 6, 3 },
                solution(new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } })
            );
        }

        static void ShowArray(int[] array)
        {
            if (array.Length == 0) return;

            Console.Write("{ ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.WriteLine(array[array.Length - 1] + " }");
        }

        static void CompareResult(int[] answer, int[] result)
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