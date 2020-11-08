using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static bool bishopCanMove(int x1, int y1, int x2, int y2)
        {
            return (Math.Abs(x2 - x1) == Math.Abs(y2 - y1));
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            while (true)
            {
                int startX = rand.Next(1, 8);
                int startY = rand.Next(1, 8);

                int finishX = rand.Next(1, 8);
                int finishY = rand.Next(1, 8);

                Console.WriteLine($"Start position of bishop is X:{startX}, Y:{startY}");
                Console.WriteLine($"Can bishop move to X:{finishX}, Y:{finishY}?");
                Console.WriteLine(bishopCanMove(startX, startY, finishX, finishY));
                Console.ReadKey();
            }
        }
    }
}