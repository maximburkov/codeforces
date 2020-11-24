using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_1
{
    class Task_B_Klaviatura : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                Console.WriteLine(Result(str));
            }
        }

        private string Result(string str)
        {
            var arr = str.ToCharArray();
            var res = new Dictionary<char, bool>();

            if (str.Length == 1)
                return str;

            int counter = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    if (counter == 1)
                    {
                        counter = 0;
                        res.TryAdd(arr[i - 1], false);
                    }
                    else
                        counter++;
                }
                else
                {
                    if(counter == 1)
                    {
                        res[arr[i - 1]] = true;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }


            if (counter == 1)
            {
                res[arr[arr.Length - 1]] = true;
            } 
            return string.Concat(res.Where(i => i.Value).Select(i => i.Key).OrderBy(i => i));
        }
    }
}
