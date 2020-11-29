using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Channels;

namespace CodeforcesHomework.Homework_1
{
    class Task_H_Obmen : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool[] swaps = Console.ReadLine().ToCharArray().Select(i => i == '1').ToArray();
            int maxCount = 200000;
            int[] dynamicSwaps = new int[n - 1];

            int[] sorted = new int[n];
            Array.Copy(arr, sorted, n);
            Array.Sort(sorted);

            int[] positions = new int[maxCount + 1];
            int[] sortedPositions = new int[maxCount + 1];

            for (int i = 0; i < maxCount; i++)
            {
                positions[i] = int.MaxValue;
                sortedPositions[i] = int.MaxValue;
            }

            for (int i = 0; i < n; i++)
            {
                positions[arr[i]] = i;
                sortedPositions[sorted[i]] = i;
            }

            dynamicSwaps[0] = swaps[0] ? 1 : 0;

            for (int i = 1; i < n - 1; i++)
            {
                dynamicSwaps[i] = swaps[i] ? dynamicSwaps[i - 1] + 1 : 0;
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > sorted[i])
                {
                    int rightIndex = sortedPositions[arr[i]];

                    if(rightIndex - i <= dynamicSwaps[rightIndex - 1]) continue;

                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
