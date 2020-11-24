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

            int[] sorted = new int[n];
            Array.Copy(arr, sorted, n);
            Array.Sort(sorted);

            int[] positions = new int[maxCount];
            int[] sortedPositions = new int[maxCount];

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

            bool needAchieve = false;
            int needAchievePosition = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != sorted[i])
                {
                    needAchievePosition = sortedPositions[arr[i]];
                    needAchieve = true;
                }

                if (needAchievePosition <= i + 1)
                {
                    needAchieve = false;
                }

                //we can achieve i+1 position with swaps[i]
                if (!swaps[i] && needAchieve)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
