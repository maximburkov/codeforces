using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesHomework.Homework_4
{
    class Task_H_Cofee_Break : ITask
    {
        public void Solve()
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int dayLength = buf[1];
            int timeBetween = buf[2];
            int skip = 0;
            int[] breaks = new int[n];

            int[] minutes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (n > 0)
            {

            }
        }
    }
}
