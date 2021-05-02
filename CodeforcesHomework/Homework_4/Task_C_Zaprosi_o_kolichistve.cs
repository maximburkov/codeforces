using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesHomework.Homework_4
{
    class Task_C_Zaprosi_o_kolichistve : ITask
    {
        private static int BinSearch(int[] a, int num)
        {
            int l = 0;
            int r = a.Length - 1;

            while (l <= r)
            {
                if(l == r)
                {
                    if(l == 0)
                    {
                        return a[l] <= num ? 1 : 0;
                    }
                    else if(l == a.Length - 1)
                    {
                        return a[l] <= num ? a.Length : l;
                    }
                }

                int m = (l + r) / 2;

                if (a[m] > num && m > 0 && a[m - 1] <= num)
                {
                    return m;
                }
                else if(a[m] < num)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }     
            }

            return -1;
        }

        public void Solve()
        {
            int[] ReadArray () => Console.ReadLine().Split().Select(int.Parse).ToArray();

            var buf = ReadArray();
            int aCount = buf[0];
            int bCount = buf[1];

            int[] a = ReadArray();
            int[] b = ReadArray();
            int[] res = new int[bCount];


            Array.Sort(a);

            for (int i = 0; i < b.Length; i++)
            {
                res[i] = BinSearch(a, b[i]);
            }

            Console.WriteLine(string.Join(' ', res));
        }
    }
}
