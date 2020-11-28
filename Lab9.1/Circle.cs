using System;

namespace Lab9._1
{
    public class Circle : Shape
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
        public override string Color { get; set; }
        public override int HighCounter { get; set; }
        public override string Name { get; set; }
        public double Radius { get; set; }

        public override double CalculateSquare()
        {
            return Math.PI * Math.Sqrt(Radius);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}