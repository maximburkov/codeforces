using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_1
{
    class Task_E_Shahmaty : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            var players = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(players);

            int worstWinner = players[n];
            int bestLoser = players[n -1];
            
            Console.WriteLine(worstWinner > bestLoser ? "YES" : "NO");
        }
    }
}
