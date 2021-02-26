using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_3
{
    class Task_H_Slagaemie : ITask
    {
        public void GetTerms(int remain, int maxTerm, int maxCount, List<int> terms, ref int totalCount)
        {
            if (remain == 0)
            {
                totalCount++;
            }

            for (int term = maxTerm; term > 0; term--)
            {
                if (term <= remain && terms.Count < maxCount)
                {
                    terms.Add(term);
                    GetTerms(remain - term, term, maxCount, terms, ref totalCount);
                    terms.Remove(term);
                }
            }
        }

        public void Solve()
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int maxCount = buf[1];
            int totalCount = 0;
            GetTerms(n, n, maxCount, new List<int>(), ref totalCount);
            Console.WriteLine(totalCount);
        }
    }
}
