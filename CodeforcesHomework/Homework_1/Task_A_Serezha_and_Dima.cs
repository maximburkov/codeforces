using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_1
{
    class Task_A_Serezha_and_Dima : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            int[] cards = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sergeyPoints = 0, dimaPoints = 0;
            int leftPointer = 0;
            int rightPointer = n - 1;

            for (int i = 0; i < n; i++)
            {
                int leftValue = cards[leftPointer];
                int rightValue = cards[rightPointer];
                int points;

                if (leftValue > rightValue)
                {
                    points = leftValue;
                    leftPointer++;
                }
                else
                {
                    points = rightValue;
                    rightPointer--;
                }

                if (i % 2 == 0)
                    sergeyPoints += points;
                else
                    dimaPoints += points;
            }

            Console.WriteLine($"{sergeyPoints} {dimaPoints}");
        }
    }
}
