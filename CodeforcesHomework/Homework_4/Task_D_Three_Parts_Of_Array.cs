using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesHomework.Homework_4
{
    class Task_D_Three_Parts_Of_Array : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long sum = 0;

            int l = 0;
            int r = n - 1;
            long firstSum = arr[l];
            long thirdSum = arr[r];

            while (l < r)
            {
                if(thirdSum > firstSum)
                {
                    l++;
                    firstSum += l != r ? arr[l] : 0;
                }
                else if(firstSum > thirdSum)
                {
                    r--;
                    thirdSum += r != l ? arr[r] : 0;
                }
                else
                {
                    sum = firstSum;
                    l++;
                    firstSum += l != r ? arr[l] : 0;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
