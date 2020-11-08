using System;
using System.Data.SqlTypes;

namespace Lab6
{
    class Program
    {
        public static int ReverseString(ref int nums)
        {
            string str = nums.ToString();
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            str = new string(charArr);
            return Convert.ToInt32(str);

        }

        public static double ReverseString(ref double doStr)
        {
            string str = doStr.ToString();
            string[] separatedString = str.Split(',', '.');
            char[] charArr1 = separatedString[0].ToCharArray();
            char[] charArr2 = separatedString[1].ToCharArray();
            Array.Reverse(charArr1);
            Array.Reverse(charArr2);
            str = String.Join(",", new string(charArr1), new string(charArr2));
            return Convert.ToDouble(str);
        }

        public static string ReverseString(ref string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        public static string ReverseString(ref string doubleString, char magicSeparator)
        {
            string[] separatedString = doubleString.Split(magicSeparator);
            char[] charArr1 = separatedString[0].ToCharArray();
            char[] charArr2 = separatedString[1].ToCharArray();
            Array.Reverse(charArr1);
            Array.Reverse(charArr2);
            string str = String.Join(Convert.ToString(magicSeparator), new string(charArr1), new string(charArr2));
            return str;

        }

        public static void ReverseArray(ref int [] arr)
        {
            int[] bufferArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                bufferArr[i] = arr[arr.Length - i - 1];
            }

            arr = bufferArr;
        }

        public static void ReverseArray(ref int[] arr, out int[] reversedArr)
        {
            reversedArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - i - 1];
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine($"Arr[{i}] = {arr[i]}");
            }
        }

        static void Main(string[] args)
        {
            int nums;
            while (true)
            {
                
                try
                {
                    Console.Write("Enter some NUMBERS: ");
                    nums = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("I will ask you to enter NUMBERS until you enter NUMBERS");
                    continue;
                }
            }
            
            
            string str = "ABCD";
            string magicStr = "ABCD.EFGH";
            double doNum = 123.456;

            int[] numsArr = new int[10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] reversedNumsArr;
            //Before reverse
            Console.WriteLine("All data before reverse: ");
            Console.WriteLine(nums);
            Console.WriteLine(str);
            Console.WriteLine(magicStr);
            Console.WriteLine(doNum);
            PrintArray(numsArr);
            //After reverse
            Console.WriteLine();
            Console.WriteLine("All data after reverse: ");
            Console.WriteLine(ReverseString(ref nums));
            Console.WriteLine(ReverseString(ref str));
            Console.WriteLine(ReverseString(ref doNum));
            Console.WriteLine(ReverseString(ref magicStr, '.'));

            Console.WriteLine("Reversing array via \"ref\"...");
            ReverseArray(ref numsArr);
            PrintArray(numsArr);
            Console.WriteLine("Reversing the same array again \"via\" ref and with \"out\"");
            ReverseArray(ref numsArr, out reversedNumsArr);
            PrintArray(reversedNumsArr);
            Console.ReadKey();
        }
    }
}