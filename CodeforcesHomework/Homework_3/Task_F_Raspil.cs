using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_3
{
    class Task_F_Raspil : ITask
    {
        public void Solve()
        {
            int[] buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int bitcoinCount = buf[1];
            int[] trees = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> cuts = new List<int>();

            int balance = 0;
            for (int i = 0; i < n; i++)
            {
                balance += (trees[i] % 2 == 0 ? -1 : 1);
                
                if (balance == 0 && i != n - 1) 
                {
                    cuts.Add(Math.Abs(trees[i + 1] - trees[i]));
                }
            }

            var sortedCuts = cuts.OrderBy(c => c).ToList();
            int totalCuts = 0;
            while (bitcoinCount > 0 && totalCuts < sortedCuts.Count)
            {
                bitcoinCount -= sortedCuts[totalCuts];
                if (bitcoinCount >= 0)
                {
                    totalCuts++;
                }
            }

            Console.WriteLine(totalCuts);
        }
    }
}
