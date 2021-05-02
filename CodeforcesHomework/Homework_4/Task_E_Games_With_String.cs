using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesHomework.Homework_4
{
    class Task_E_Games_With_String : ITask
    {
        public void Solve()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            bool isFirst = true;

            for (int i = 0; i < input.Length; i++)
            {
                if(stack.Count > 0 && stack.Peek() == input[i])
                {
                    stack.Pop();
                    isFirst = !isFirst;
                }
                else
                {
                    stack.Push(input[i]);
                }
            }

            Console.WriteLine(isFirst ? "No" : "Yes");
        }
    }
}
