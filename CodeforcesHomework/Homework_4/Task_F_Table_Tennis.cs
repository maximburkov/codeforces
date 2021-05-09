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
            int[] players = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if(maxCount > n)
            {
                Console.WriteLine(players.Max());
                return;
            }

            Queue<int> queue = new Queue<int>(players);
            int winner = queue.Dequeue();

            while (currentCount < maxCount)
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
