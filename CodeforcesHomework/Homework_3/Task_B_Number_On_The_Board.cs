using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_3
{
    class Task_B_Number_On_The_Board : ITask
    {
        public void Solve()
        {
            string sumThatWasBeforeString = Console.ReadLine();
            string numberNowString = Console.ReadLine();
            int sumThatWasBefore = int.Parse(sumThatWasBeforeString);
            
            int[] numberArr = numberNowString.ToCharArray().Select(c => (int)char.GetNumericValue(c)).ToArray();
            Array.Sort(numberArr);
            
            int sumNow = 0;
            foreach (var num in numberArr)
            {
                sumNow += num;
            }

            if (sumNow >= sumThatWasBefore)
            {
                Console.WriteLine(0);
            }
            else
            {
                int count = 0;
                for (int i = 0; i < numberArr.Length && sumNow < sumThatWasBefore; i++)
                {
                    sumNow += (9 - numberArr[i]);
                    count++;
                }

                Console.WriteLine(count);
            }
        }
    }
}
