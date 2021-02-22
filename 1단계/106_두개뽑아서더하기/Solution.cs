using System;
using System.Collections.Generic;
using System.Linq;
namespace _106
{
    class Solution
    {
        public void PrintSample()
        {
            CompareResult(new int[] { 2, 1, 3, 4, 1 }, solution(new int[] { 2, 3, 4, 5, 6, 7 }));
            CompareResult(new int[] { 5, 0, 2, 7 }, solution(new int[] { 2, 5, 7, 9, 12 }));
        }
        public int[] solution(int[] numbers)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    list.Add(numbers[i] + numbers[j]);
                }
            }
            int[] temp = list.Distinct().ToArray();
            Array.Sort(temp);
            return temp;
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
    }

}
