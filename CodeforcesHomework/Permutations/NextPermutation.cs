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
            int indexToSwap = 0;
            for (int i = A.Count - 1; i > 0; i--)
            {
                if (A[i] >= A[i - 1])
                {
                    indexToSwap = i;
                }
            }

            int compareWith = A[indexToSwap];
            int nextIndex = 0;
            int nextNumber = int.MaxValue;

            for (int i = indexToSwap + 1; i < A.Count; i++)
            {
                if (A[i] <= nextNumber && A[i] >= compareWith)
                {
                    nextIndex = i;
                    nextNumber = A[i];
                }
            }

            // swap
            int buf = A[indexToSwap];
            A[indexToSwap] = nextNumber;
            A[nextIndex] = buf;

            return A.Take(indexToSwap + 1).Concat(A.Skip(indexToSwap + 1).Take(A.Count - indexToSwap).Reverse())
                .ToList();
        }
    }
}
