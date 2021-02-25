using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_3
{
    class Task_C_Perestanovka : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Enumerable.Range(1,n).Except(Console.ReadLine().Split().Select(int.Parse).ToArray()).Count());
        }
    }
}
