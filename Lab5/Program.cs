using System;

namespace Lab5
{
    internal class Program
    {
        private static void PrintMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (j % matrix.GetLength(1) == 0) Console.WriteLine();
                Console.Write("{0, 3}", matrix[i, j]);
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            var rn = new Random();
            for (var i = 0; i < matrix.GetLength(0); i++)
            for (var j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = rn.Next(1, 50);
        }

        private static void Main()
        {
            var n = 0;
            var m = 0;

            Console.WriteLine("Желаете ввести размер матрицы или получить случайно?\n1)Ввести\n2)Случайно\n");
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Введите кол-во столбцов:");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите кол-во рядков:");
                    m = Convert.ToInt32(Console.ReadLine());

                    break;
                case 2:
                    var rn = new Random();
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

            var matrix = new int[n, m];

            FillMatrix(matrix);
            PrintMatrix(matrix);
            var k = false;

            var rowsCounter = 0;
            var colsCounter = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m - 1; j++)
                {
                    var a = matrix[i, j];
                    var b = matrix[i, j + 1];

                    if (a <= b)
                    {
                        k = true;
                    }
                    else
                    {
                        k = false;
                        break;
                    }
                }

                if (k)
                    rowsCounter++;
            }

            for (var j = 0; j < m; j++)
            {
                for (var i = 0; i < n - 1; i++)
                {
                    var a = matrix[i, j];
                    var b = matrix[i + 1, j];

                    if (a <= b)
                    {
                        k = true;
                    }
                    else
                    {
                        k = false;
                        break;
                    }
                }

                if (k)
                    colsCounter++;
            }

            Console.WriteLine($"\n\nРядков монотонно растут:{rowsCounter}\n Столбцов монотонно растут:{colsCounter}");
            Console.ReadKey();
        }
    }
}