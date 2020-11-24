using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_1
{
    class Task_D_Sortirovka : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];

            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            var sortedStrings = strings.OrderBy(i => i.Length).ToArray();
            bool isOk = true;

            for (int i = 1; i < n; i++)
            {
                if (!sortedStrings[i].Contains(sortedStrings[i - 1]))
                    isOk = false;
            }

            Console.WriteLine(isOk ? "YES" : "NO");

            if(isOk)
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(sortedStrings[i]);
                }
        }
    }
}
