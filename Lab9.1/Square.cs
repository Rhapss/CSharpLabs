using System;

namespace Lab9._1
{
    public class Square : Shape
    {
        Random rnd = new Random();
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
        
        public override string Color { get; set; }
        public override int HighCounter { get; set; }
        public override string Name { get; set; }
        public double TurnLenght { get; set; }

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