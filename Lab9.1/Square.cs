using System;

namespace Lab9._1
{
    public class Square : Shape, IDraw
    {
        private readonly Random rnd = new Random();

        public Square(string name)
        {
            Name = name;
            Color = "Undefined";
            HighCounter = 4;
            TurnLenght = rnd.Next(100);
        }

        public Square(string name, double turnLenght)
        {
            Name = name;
            Color = "Indefined";
            HighCounter = 4;
            TurnLenght = turnLenght;
        }

        public Square(string name, double turnLenght, string color)
        {
            Name = name;
            Color = color;
            HighCounter = 4;
            TurnLenght = turnLenght;
        }

        public sealed override string Color { get; set; }
        public sealed override int HighCounter { get; set; }
        public sealed override string Name { get; set; }
        public double TurnLenght { get; set; }

        public override void Draw()
        {
            Console.WriteLine($"Name of figure: {Name}\n" +
                              "Size of figure: \n" +
                              $"Turn Length - {TurnLenght}\n" +
                              $"Square of figure - {CalculateSquare()}cm^2\n" +
                              $"Perimeter of figure - {CalculatePerimeter()}cm\n" +
                              $"Color of figure is: {Color}\n" +
                              "----Figure drawn----");
        }

        public override double CalculateSquare()
        {
            return TurnLenght * TurnLenght;
        }

        public override double CalculatePerimeter()
        {
            return TurnLenght * 4;
        }
    }
}