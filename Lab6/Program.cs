using System;

namespace Lab6
{
    internal class Program
    {
        public static int ReverseString(ref int nums)
        {
            var str = nums.ToString();
            var charArr = str.ToCharArray();
            Array.Reverse(charArr);
            str = new string(charArr);
            return Convert.ToInt32(str);
        }

        public static double ReverseString(ref double doStr)
        {
            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            var str = doStr.ToString();
            var separatedString = str.Split(',', '.');
            var charArr1 = separatedString[0].ToCharArray();
            var charArr2 = separatedString[1].ToCharArray();
            Array.Reverse(charArr1);
            Array.Reverse(charArr2);
            str = string.Join(",", new string(charArr1), new string(charArr2));
            return Convert.ToDouble(str);
        }

        public static string ReverseString(ref string str)
        {
            var charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        public static string ReverseString(ref string doubleString, char magicSeparator)
        {
            var separatedString = doubleString.Split(magicSeparator);
            var charArr1 = separatedString[0].ToCharArray();
            var charArr2 = separatedString[1].ToCharArray();
            Array.Reverse(charArr1);
            Array.Reverse(charArr2);
            var str = string.Join(Convert.ToString(magicSeparator), new string(charArr1), new string(charArr2));
            return str;
        }

        public static void ReverseArray(ref int[] arr)
        {
            var bufferArr = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++) bufferArr[i] = arr[arr.Length - i - 1];

            arr = bufferArr;
        }

        public static void ReverseArray(ref int[] arr, out int[] reversedArr)
        {
            reversedArr = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++) reversedArr[i] = arr[arr.Length - i - 1];
        }

        public static void PrintArray(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++) Console.WriteLine($"Arr[{i}] = {arr[i]}");
        }

        private static void Main()
        {
            int nums;
            while (true)
                try
                {
                    Console.Write("Enter some NUMBERS: ");
                    nums = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("I will ask you to enter NUMBERS until you enter NUMBERS");
                }

            var str = "ABCD";
            var magicStr = "ABCD.EFGH";
            var doNum = 123.456;
            var numsArr = new[] {1, 3, 5, 7, 9, 11, 13, 15, 17, 19};
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