using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesHomework.Homework_4
{
    class Task_G_Registration_System : ITask
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> database = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                if (database.ContainsKey(name))
                {
                    Console.WriteLine($"{name}{database[name]}");
                    database[name]++;
                }
                else
                {
                    database.Add(name, 1);
                    Console.WriteLine("OK");
                }
            }
        }
    }
}
