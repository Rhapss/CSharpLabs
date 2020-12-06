using System;

namespace Lab10
{
    internal static class Program
    {
        
        public static void Main(string[] args)
        {
            int[] array = new[] {1, 4, 5, 1, 3, 235, 634, 234, 12, 4, 3, 77, 141};
            array.PrintArray();

            int nums = 1234567890;
            nums.ReverseString();
            
            array.ReverseArray();
            
            Console.WriteLine();
            foreach (var elem in array)
            {
                Console.Write($"{elem} _ ");
            }
        }
    }
}