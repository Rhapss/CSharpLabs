using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte r1 = (byte)rand.Next(1, 10);
            byte r2 = (byte)rand.Next(1, 10); 
            byte r3 = (byte)rand.Next(1, 10);

            int result = r1 + r2 + r3;
            Console.WriteLine($"Сопротивление цепи с такими резисторами: {r1}, {r2}, {r3} = {result}");
            Console.ReadKey();
        }
    }
}
