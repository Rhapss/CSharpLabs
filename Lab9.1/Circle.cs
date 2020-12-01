using System;

namespace Lab9._1
{
    public class Circle : Shape, IDraw
    {
        Random rnd = new Random();
        public Circle(string name)
        {
            Name = name;
            Color = "Undefined";
            HighCounter = 0;
            Radius = rnd.Next(100);
        }

        public Circle(string name, double radius)
        {
            Name = name;
            Color = "Indefined";
            HighCounter = 0;
            Radius = radius;

        }

        public Circle(string name, double radius, string color)
        {
            Name = name;
            Color = color;
            HighCounter = 0;
            Radius = radius;
        }
        public sealed override string Color { get; set; }
        public sealed override int HighCounter { get; set; }
        public sealed override string Name { get; set; }
        public double Radius { get; set; }

        public override double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Name of figure: {Name}\n" +
                              $"Size of figure: \n" +
                              $"Radius - {Radius}\n" +
                              $"Square of figure - {CalculateSquare()}cm^2\n" +
                              $"Perimeter of figure - {CalculatePerimeter()}cm\n" +
                              $"Color of figure is: {Color}\n" +
                              $"----Figure drawn----");
        }
    }
}