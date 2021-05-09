using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesHomework.Homework_4
{
    class Task_K_Replace_To_Right_Sequence : ITask
    {
        public void Solve()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            int replaceCount = 0;

            bool IsOpen(char c) => c == '(' || c == '[' || c == '{' || c == '<';
            bool IsClose(char c) => c == ')' || c == ']' || c == '}' || c == '>';
            int GetType(char c) => c switch
            {
                '(' => 0,
                ')' => 0,

                '[' => 1,
                ']' => 1,

                '{' => 2,
                '}' => 2,

                '<' => 3,
                '>' => 3,

                _ => throw new NotImplementedException()
            };

            for (int i = 0; i < input.Length; i++)
            {
                char cur = input[i];

                if (stack.Any() && IsOpen(stack.Peek()) && IsClose(cur))
                {
                    if (GetType(cur) != GetType(stack.Peek()))
                        replaceCount++;
                    
                    stack.Pop();
                }
                else
                {
                    stack.Push(cur);
                }
            }

            Console.WriteLine(stack.Count == 0 ? replaceCount.ToString() : "Impossible");
        }
    }
}
