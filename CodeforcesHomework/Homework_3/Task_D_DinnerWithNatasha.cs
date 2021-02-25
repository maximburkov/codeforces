using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeforcesHomework.Homework_3
{
    class Task_D_DinnerWithNatasha : ITask
    {
        public void Solve()
        {
            int[] buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int m = buf[1];
            List<List<int>> rests = new List<List<int>>(n);

            for (int i = 0; i < n; i++)
                rests.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
            
            Console.WriteLine(rests.Max(r => r.Min()));
        }
    }
}
