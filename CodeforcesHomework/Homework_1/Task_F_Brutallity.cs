using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_1
{
    class Task_F_Brutallity : ITask
    {
        public void Solve()
        {
            var buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = buf[0];
            int k = buf[1];

            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var s = Console.ReadLine().ToCharArray();

            int totalDamage = 0;
            int rowLength = 1;
            int rowDamage = a[0];

            //int startIndex = 0;
            //int finishIndex = 0;

            //while (finishIndex != n)
            //{
            //    if(startIndex == finishIndex)
            //    {

            //    }
            //}




            for (int i = 1; i < n; i++)
            {
                if (s[i] != s[i - 1])
                {
                    if (rowLength <= k)
                        totalDamage += rowDamage;
                    else
                    {
                        int startIndex = i - rowLength;
                        var tempArray = new int[rowLength];
                        Array.Copy(a, startIndex, tempArray, 0, rowLength);
                        Array.Sort(tempArray);
                        var bestItems = new int[k];
                        Array.Copy(tempArray, rowLength - k, bestItems, 0, k);
                        totalDamage += bestItems.Sum();
                    }

                    rowLength = 1;
                    rowDamage = a[i];
                }
                else
                {
                    rowLength++;
                    rowDamage += a[i];
                }
            }

            if (rowLength <= k)
                totalDamage += rowDamage;
            else
            {
                int startIndex = n - rowLength;
                var tempArray = new int[rowLength];
                Array.Copy(a, startIndex, tempArray, 0, rowLength);
                Array.Sort(tempArray);
                var bestItems = new int[k];
                Array.Copy(tempArray, rowLength - k, bestItems, 0, k);
                totalDamage += bestItems.Sum();
            }

            Console.WriteLine(totalDamage);
        }
    }
}
