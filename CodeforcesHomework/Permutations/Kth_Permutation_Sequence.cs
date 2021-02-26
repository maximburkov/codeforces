using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Permutations
{
    class Kth_Permutation_Sequence : ITask
    {
        private int[] factorials;
        private void FillFactorial(int n)
        {
            factorials = new int[n + 1];
            factorials[0] = 1;
            for (int i = 1; i < n; i++)
                factorials[i] = factorials[i - 1] * i;
        }

        private int GetFactorial(int n) => factorials?[n] ?? 1;

        private int GetAvailable(int index, bool[] available, int[] range)
        {
            int j = 0;
            for (int i = 0; i < available.Length; i++)
            {
                if (available[i])
                {
                    if (j == index)
                    {
                        available[i] = false;
                        return range[i];
                    }
                    j++;
                }
            }
            throw new ArgumentException("Available Not Found!");
        }

        public string GetPermutation(int A, int B)
        {
            int n = A, k = B - 1;
            FillFactorial(n);
            string result = string.Empty;
            bool[] available = Enumerable.Repeat(true, n).ToArray();
            int[] range = Enumerable.Range(1, n).ToArray();

            int remain = k;
            for (int i = 0; i < n; i++)
            {
                int factorial = GetFactorial(n - i - 1);
                int index = remain / factorial;
                remain = k % factorial;
                result += GetAvailable(index, available, range);
            }

            return result;
        }

        public void Solve() =>
            Console.WriteLine(GetPermutation(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
    }
}
