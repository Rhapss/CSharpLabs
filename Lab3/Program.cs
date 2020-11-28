using System;

namespace Lab3
{
    internal class Program
    {
        private static bool bishopCanMove(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x2 - x1) == Math.Abs(y2 - y1);
        }

        private static void Main(string[] args)
        {
            var rand = new Random();
            while (true)
            {
                var startX = rand.Next(1, 8);
                var startY = rand.Next(1, 8);

                var finishX = rand.Next(1, 8);
                var finishY = rand.Next(1, 8);

                Console.WriteLine($"Start position of bishop is X:{startX}, Y:{startY}");
                Console.WriteLine($"Can bishop move to X:{finishX}, Y:{finishY}?");
                Console.WriteLine(bishopCanMove(startX, startY, finishX, finishY));
                Console.ReadKey();
            }
        }
    }
}