using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % matrix.GetLength(1) == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(string.Format("{0, 3}", matrix[i, j]));
                }
            }
        }

        static void FillMatrix(int[,] matrix)
        {
            Random rn = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rn.Next(1, 50);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;

            Console.WriteLine("Желаете ввести размер матрицы или получить случайно?\n1)Ввести\n2)Случайно\n");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Введите кол-во столбцов:");
                    n = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите кол-во рядков:");
                    m = Int32.Parse(Console.ReadLine());

                    break;
                case 2:
                    Random rn = new Random();
                    Console.Clear();

                    n = rn.Next(2, 4);
                    m = rn.Next(2, 4);
                    Console.WriteLine($"Ваш размер матрицы: {n}x{m}\n");

                    break;
            }
            //int[,] matrix = new int[4, 5]
            //{
            //    {1, 2, 4, 1, 0},
            //    {3, 3, 6, 9, 11},
            //    {3, 4, 7, 11, 1},
            //    {3, 41, 11, 12, 8}
            //};

            int[,] matrix = new int[n, m];

            FillMatrix(matrix);
            PrintMatrix(matrix);
            bool k = false;

            int rowsCounter = 0;
            int colsCounter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    int a = matrix[i,j];
                    int b = matrix[i,j + 1];

                    if (a<=b)
                        k = true;
                    else
                    {
                        k = false;
                        break;
                    }
                }
                if (k == true)
                    rowsCounter++;
            }
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int a = matrix[i, j];
                    int b = matrix[i + 1, j];

                    if (a <= b)
                        k = true;
                    else
                    {
                        k = false;
                        break;
                    }
                }
                if (k == true)
                    colsCounter++;
            }
            Console.WriteLine($"\n\nРядков монотонно растут:{rowsCounter}\n Столбцов монотонно растут:{colsCounter}");
            Console.ReadKey();
        }
    }
}

