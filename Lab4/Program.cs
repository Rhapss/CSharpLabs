using System;

namespace Lab4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = 0;

            Console.WriteLine("Желаете ввести размер массива или получить случайно?\n1)Ввести\n2)Случайно\n");
            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите размер массива:");
                    n = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    var randSize = new Random();
                    Console.Clear();
                    n = randSize.Next(10, 20);
                    Console.WriteLine($"Ваш размер массива: {n}");
                    break;
            }

            var arr = new int[n];

            Console.WriteLine("Элементы массива:");
            var randElem = new Random();
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = randElem.Next(1, 20);
                Console.Write($"{arr[i]}, ");
            }

            var minDif = 30;
            var index1 = 0;
            var index2 = 0;

            for (var i = 0; i < arr.Length - 1; i++)
            for (var j = i + 1; j < arr.Length; j++)
                if (Math.Abs(arr[i] - arr[j]) < minDif)
                {
                    index1 = i;
                    index2 = j;
                    minDif = Math.Abs(arr[i] - arr[j]);
                }

            Console.WriteLine(
                $"\nЭлемент [{index1}]({arr[index1]}) и Элемент [{index2}]({arr[index2]}) ближе всего друг к другу.");
            Console.ReadKey();
        }
    }
}