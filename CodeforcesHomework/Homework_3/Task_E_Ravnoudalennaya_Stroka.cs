using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_3
{
    class Task_E_Ravnoudalennaya_Stroka : ITask
    {
        public void Solve()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int sCount = s.Count(c => c == '1');
            int tCount = t.Count(c => c == '1');

            if ((sCount - tCount) % 2 == 0)
            {
                int oneCount = (sCount + tCount) / 2;

                var res = string.Empty.PadRight(oneCount, '1').PadLeft(s.Length, '0');
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("impossible");
            }
        }
    }
}
