using System;

namespace Lab9._1
{
    public class Triangle : Shape
    {
        Random rnd = new Random();
        public Triangle(string name)
        {
            Name = name;
            Color = "Undefined";
            HighCounter = 0;
            TurnLenght = rnd.Next(100);
        }

        public Triangle(string name, double turnLenght)
        {
            Name = name;
            Color = "Indefined";
            HighCounter = 0;
            TurnLenght = turnLenght;

        }

        public Triangle(string name, double highCounter, string color)
        {
            Name = name;
            Color = color;
            HighCounter = 0;
            TurnLenght = TurnLenght;
        }
        public override string Color { get; set; }
        public override int HighCounter { get; set; }
        public override string Name { get; set; }
        public double TurnLenght { get; set; }

        public override double CalculateSquare()
        {
            return Math.Sqrt(3) / 4 * Math.Sqrt(TurnLenght);
        }

        public override double CalculatePerimeter()
        {
            return TurnLenght * 3;
        }
    }
}