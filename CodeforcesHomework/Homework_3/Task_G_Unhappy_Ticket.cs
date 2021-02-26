using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_3
{
    class Task_G_Unhappy_Ticket : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().ToCharArray().Select(c => (int)char.GetNumericValue(c)).ToList();

            List<int> first = numbers.Take(n).OrderBy(i => i).ToList();
            List<int> second = numbers.Skip(n).OrderBy(i => i).ToList();

            bool allBigger = true;
            bool allSmaller = true;
            for (int i = 0; i < n; i++)
            {
                if (first[i] <= second[i])
                {
                    allBigger = false;
                }
            }

            if (allBigger)
            {
                Console.WriteLine("YES");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (first[i] >= second[i])
                {
                    allSmaller = false;
                }
            }

            if (allSmaller)
            {
                Console.WriteLine("YES");
                return;
            }

            Console.WriteLine("NO");
        }
    }
}
