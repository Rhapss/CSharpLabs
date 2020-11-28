using System;

namespace Lab1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int r1 = 0, r2 = 0, r3 = 0;
            Console.WriteLine("Введите сопротивление 3х резисторов:");
            Console.Write("R1:");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("R2:");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("R3:");
            r3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(
                $"Сопротивление трёх последовательно соединённых резисторов будет составлять: {r1 + r2 + r3} Ом");
        }
    }
}