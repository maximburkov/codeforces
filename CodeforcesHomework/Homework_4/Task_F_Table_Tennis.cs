using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesHomework.Homework_4
{
    class Task_F_Table_Tennis : ITask
    {
        public void Solve()
        {
            long[] buf = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = buf[0];
            long maxCount = buf[1];
            long currentCount = 0;
            Queue<int> queue =  new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int winner = 0;

            while(currentCount < maxCount)
            {
                int rival = queue.Dequeue();
                
                if(rival > winner)
                {
                    queue.Enqueue(winner);
                    winner = rival;
                    currentCount = 1;
                }
                else
                {
                    queue.Enqueue(rival);
                    currentCount++;
                }
            }

            Console.WriteLine(winner);
        }
    }
}
