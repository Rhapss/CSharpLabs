using System;

namespace Lab9._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Square square = new Square("Cube", 4.4);
            Circle circle = new Circle("Ball", 12.43, "rainbow");
            Triangle triangle = new Triangle("Pyramid");

            Console.WriteLine($"Square Perimeter: {square.CalculatePerimeter()} cm");
            Console.WriteLine($"Square Square: {square.CalculateSquare()} cm^2");

            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()} cm");
            Console.WriteLine($"Circle Square: {circle.CalculateSquare()} cm^2");
            
            Console.WriteLine($"Triangle Perimeter: {triangle.CalculatePerimeter()} cm");
            Console.WriteLine($"Triangle Square: {triangle.CalculateSquare()} cm^2");
            
            Picture pic = new Picture();
            
            pic.AddShape(square);
            pic.AddShape(circle);
            pic.AddShape(triangle);
            
            pic.ShowShapes(pic.Collection);
            Console.WriteLine("~~~~~~~Deleting element by type (Circle)~~~~~~~");
            pic.DeleteShape(typeof(Circle));
            pic.ShowShapes(pic.Collection);
            
            pic.Draw();
            
            Painter painter = new Painter(square);
            
            painter.Draw();
        }
    }
}