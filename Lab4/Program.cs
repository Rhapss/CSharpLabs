using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Желаете ввести размер массива или получить случайно?\n1)Ввести\n2)Случайно\n");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Введите размер массива:");
                    n = Int32.Parse(Console.ReadLine());
                    break;
                case 2:
                    Random randSize = new Random();
                    Console.Clear();
                    n = randSize.Next(10, 20);
                    Console.WriteLine($"Ваш размер массива: {n}");
                    break;
            }
            
            int[] arr = new int[n];

            Console.WriteLine("Элементы массива:");
            Random randElem = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randElem.Next(1, 20);
                Console.Write($"{arr[i]}, ");
            }

            int minDif = 30;
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) < minDif)
                    {
                        index1 = i;
                        index2 = j;
                        minDif = Math.Abs(arr[i] - arr[j]);
                    }
                }
            }
            Console.WriteLine($"\nЭлемент [{index1}]({arr[index1]}) и Элемент [{index2}]({arr[index2]}) ближе всего друг к другу.");
            Console.ReadKey();
        }
    }
}
