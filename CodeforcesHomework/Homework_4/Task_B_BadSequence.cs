using System;
using System.Collections.Generic;
using System.Text;

namespace CodeforcesHomework.Homework_4
{
    class Task_B_BadSequence : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>(arr.Length);

            if (n == 0)
            {
                Console.WriteLine("Yes");
                return;
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                var b = arr[i];
                if (b == '(')
                {
                    stack.Push(b);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(b);
                    }
                    else
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(b);
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Yes");
            }
            else if (stack.Count == 2)
            {
                var first = stack.Pop();
                var second = stack.Pop();
                Console.WriteLine(first == second ? "No" : "Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
