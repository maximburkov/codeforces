using System;
using System.Collections;
using CodeforcesHomework.Greedy;
using CodeforcesHomework.Homework_1;
using CodeforcesHomework.Homework_3;
using CodeforcesHomework.Homework_4;
using CodeforcesHomework.Permutations;

namespace CodeforcesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ITask task = new Task_L_Cd_And_Pwd();
            task.Solve();
        }
    }
}


#region Paste Task to Test
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace CodeforcesHomework
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] charArr = Console.ReadLine().ToCharArray();
//            int n = int.Parse(Console.ReadLine());
//            int[] results = new int[charArr.Length];

//            for (int i = 1; i < charArr.Length; i++)
//            {
//                results[i] = charArr[i] == charArr[i - 1] ? results[i - 1] + 1 : results[i - 1];
//            }

//            for (int i = 0; i < n; i++)
//            {
//                int[] buf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//                int left = buf[0] - 1;
//                int right = buf[1] - 1;
//                Console.WriteLine(results[right] - results[left]);
//            }
//        }
//    }
//}
#endregion

