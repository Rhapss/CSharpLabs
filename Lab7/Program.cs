using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7
{
    internal class Program
    {
        private static void GenerateList(ref List<int> nums)
        {
            var rand = new Random();
            for (var i = 0; i < 1000; i++) nums.Add(rand.Next(10));
        }

        private static void CountRepeatedNums(List<int> num)
        {
            num.Sort();

            var result = new Dictionary<int, int>();

            for (var i = 1; i < num.Count; i++)
                if (num[i] == num[i - 1])
                {
                    if (!result.Keys.Contains(num[i]))
                        result.Add(num[i], 1);
                    else
                        result[num[i]]++;
                }

            foreach (var key in result.Keys)
                if (result[key] > 1)
                    Console.WriteLine($"Number {key} occurs {result[key]} times.");
        }

        private static void Main()
        {
            var nums = new List<int>();
            GenerateList(ref nums);
            CountRepeatedNums(nums);
            Console.ReadKey();
            
            
        }
    }
}