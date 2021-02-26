using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Permutations
{
    class Permutations : ITask
    {
        private List<List<int>> permutations = new List<List<int>>();

        public void FindPermutations(List<int> added, List<int> toAdd, int n)
        {
            if (added.Count == n)
            {
                permutations.Add(added);
                return;
            }

            foreach (var item in toAdd.ToList())
            {
                added.Add(item);
                toAdd.Remove(item);
                FindPermutations(added.ToList(), toAdd.ToList(), n);
                added.Remove(item);
                toAdd.Add(item);
            }
        }
        
        public List<List<int>> Permute(List<int> A)
        {
            FindPermutations(new List<int>(A.Count), A, A.Count);
            return permutations;
        }

        public void Solve()
        {
            var res = Permute(new List<int> {1, 2, 3});
        }
    }
}
