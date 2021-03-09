using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeforcesHomework.Greedy
{
    class HighestProduct : ITask
    {
        private int maxProduct = Int32.MinValue;
        public void FindMaxProduct(List<int> added, List<int> toAdd, int n)
        {
            if (added.Count == n)
            {
                int product = added.Aggregate(1, (i, i1) => i * i1);
                maxProduct = Math.Max(maxProduct, product);
            }

            foreach (var item in toAdd.ToList())
            {
                added.Add(item);
                toAdd.Remove(item);
                FindMaxProduct(added.ToList(), toAdd.ToList(), n);
                added.Remove(item);
                toAdd.Add(item);
            }
        }

        public int maxp3(List<int> A)
        {
            List<int> maxPositives = new List<int>(3);
            List<int> maxNegatives = new List<int>(2);
            
            foreach (var item in A)
            {
                if (item >= 0)
                {
                    if (maxPositives.Count < 3)
                    {
                        maxPositives.Add(item);
                    }
                    else
                    {
                        int min = maxPositives.Min();
                        if (min < item)
                        {
                            maxPositives.Remove(min);
                            maxPositives.Add(item);
                        }
                    }
                }
                else
                {
                    if (maxNegatives.Count < 2)
                    {
                        maxNegatives.Add(item);
                    }
                    else
                    {
                        int max = maxNegatives.Max();
                        if (max > item)
                        {
                            maxNegatives.Remove(max);
                            maxNegatives.Add(item);
                        }
                    }
                }
            }

            if (A.Count < 3)
                throw new Exception("Incorrect input data.");

            if (maxPositives.Count == 0)
            {
                return A.OrderByDescending(i => i).Take(3).Aggregate(1, (i, i1) => i * i1);
            }
            
            FindMaxProduct(new List<int>(), maxPositives.Concat(maxNegatives).ToList(), 3);

            return maxProduct;
        }

        public void Solve()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(maxp3(input));
        }
    }
}
