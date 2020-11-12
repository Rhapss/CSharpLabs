using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7
{
    class Program
    {
        static void GenerateList(ref List<int> nums)
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                nums.Add(rand.Next(10));
            }
        }

        static void CountRepeatedNums(List<int> num)
        {
            num.Sort();

            var result = new Dictionary<int, int>();

            for (int i = 1; i < num.Count; i++)
            {
                if (num[i] == num[i - 1])
                {
                    if (!result.Keys.Contains(num[i]))
                    {
                        result.Add(num[i], 1);
                    }
                    else
                    {
                        result[num[i]]++;
                    }
                }
            }

            foreach (var key in result.Keys)
            {
                if (result[key] > 1)
                {
                    Console.WriteLine($"Number {key} occurs {result[key]} times.");
                }
            }
        }

        static void Main(string[] args)
        {
            var nums = new List<int>();
            GenerateList(ref nums);
            CountRepeatedNums(nums);
            Console.ReadKey();
        }
    }
}
