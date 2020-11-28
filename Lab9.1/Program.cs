using System;

namespace Lab9._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Square square = new Square("ball", 4.4);
            Circle circle = new Circle("Pyramid", 12.43, "rainbow");
            Triangle triangle = new Triangle("cube");

            Console.WriteLine(square.CalculatePerimeter());
            Console.WriteLine(square.CalculateSquare());

            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateSquare());
            
            Console.WriteLine(triangle.CalculatePerimeter());
            Console.WriteLine(triangle.CalculateSquare());
        }
    }
}