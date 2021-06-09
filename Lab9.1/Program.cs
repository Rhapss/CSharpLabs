using System;

namespace Lab9._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var square = new Square("Cube", 4.4);
            var circle = new Circle("Ball", 12.43, "rainbow");
            var triangle = new Triangle("Pyramid");

            Console.WriteLine($"Square Perimeter: {square.CalculatePerimeter()} cm");
            Console.WriteLine($"Square Square: {square.CalculateSquare()} cm^2");

            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()} cm");
            Console.WriteLine($"Circle Square: {circle.CalculateSquare()} cm^2");

            Console.WriteLine($"Triangle Perimeter: {triangle.CalculatePerimeter()} cm");
            Console.WriteLine($"Triangle Square: {triangle.CalculateSquare()} cm^2");

            var pic = new Picture();

            pic.AddShape(square);
            pic.AddShape(circle);
            pic.AddShape(triangle);

            pic.ShowShapes(pic.Collection);
            Console.WriteLine("~~~~~~~Deleting element by type (Circle)~~~~~~~");
            pic.DeleteShape(typeof(Circle));
            pic.ShowShapes(pic.Collection);

            pic.Draw();

            var painter = new Painter(square);

            painter.Draw();
        }
    }
}