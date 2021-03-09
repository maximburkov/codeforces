using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Permutations
{
    class NextPermutation : ITask
    {
        public void Solve()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var res = nextPermutation(input);
        }

        public List<int> nextPermutation(List<int> A)
        {
            int n = A.Count;
            var sorted = A.OrderBy(i => i).ToList();
            int[] positions = new int [n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i] == sorted[j])
                        positions[i] = j;
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (positions[i] == n - 1)
                {
                    if (i == 0)
                    {
                        positions = positions.Reverse().ToArray();
                        break;
                    }

                    positions[i] = 0;
                }
                else
                {
                    positions[i]++;
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                A[i] = sorted[positions[i]];
            }

            return A;
        }
    }
}
