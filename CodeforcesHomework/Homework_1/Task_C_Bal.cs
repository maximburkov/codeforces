using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Homework_1
{
    class Task_C_Bal : ITask
    {
        public void Solve()
        {
            int boysCount = int.Parse(Console.ReadLine());
            var boys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int girlsCount = int.Parse(Console.ReadLine());
            var girls = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(boys);
            Array.Sort(girls);

            int boysCounter = 0;
            int girlsCounter = 0;
            int pairsCount = 0;

            while ((boysCounter < boysCount) && (girlsCounter < girlsCount))
            {
                if (isPair(boys[boysCounter], girls[girlsCounter]))
                {
                    pairsCount++;
                    boysCounter++;
                    girlsCounter++;
                }
                else
                {
                    if (boys[boysCounter] > girls[girlsCounter])
                        girlsCounter++;
                    else
                    {
                        boysCounter++;
                    }
                }
            }

            Console.WriteLine(pairsCount);
        }

        private bool isPair(int boy, int girl) => Math.Abs(boy - girl) <= 1;
    }
}
//TO paste:
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int boysCount = int.Parse(Console.ReadLine());
            var boys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int girlsCount = int.Parse(Console.ReadLine());
            var girls = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(boys);
            Array.Sort(girls);

            int boysCounter = 0;
            int girlsCounter = 0;
            int pairsCount = 0;

            while ((boysCounter < boysCount) && (girlsCounter < girlsCount))
            {
                if (isPair(boys[boysCounter], girls[girlsCounter]))
                {
                    pairsCount++;
                    boysCounter++;
                    girlsCounter++;
                }
                else
                {
                    if (boys[boysCounter] > girls[girlsCounter])
                        girlsCounter++;
                    else
                    {
                        boysCounter++;
                    }
                }
            }

            Console.WriteLine(pairsCount);
        }
        
        private static bool isPair(int boy, int girl) => Math.Abs(boy - girl) <= 1;
    }
}*/
