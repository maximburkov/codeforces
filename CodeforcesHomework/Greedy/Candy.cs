using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Greedy
{
    public class Candy : ITask
    {
        public int candy(List<int> A)
        {
            int n = A.Count;
            int[] ascSequence = new int[n];
            int[] descSequence = new int[n];

            ascSequence[0] = 1;
            descSequence[^1] = 1;

            for (int i = 1; i < n; i++)
            {
                if (A[i] > A[i - 1])
                {
                    ascSequence[i] = ascSequence[i - 1] + 1;
                }
                else if (A[i] < A[i - 1])
                {
                    ascSequence[i] = 1;
                }
                else
                {
                    ascSequence[i] = ascSequence[i - 1];
                }
            }

            for (int i = n - 2; i >= 0; i--)
            {
                if (A[i] > A[i + 1])
                {
                    descSequence[i] = descSequence[i + 1] + 1;
                }
                else if (A[i] < A[i + 1])
                {
                    descSequence[i] = 1;
                }
                else
                {
                    descSequence[i] = descSequence[i + 1];
                }
            }

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += Math.Max(ascSequence[i], descSequence[i]);
            }

            return result;
        }

        public void Solve()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(candy(input));
        }
    }
}
