namespace Lab9._1
{
    public abstract class Shape
    {
        public abstract string Color { get; set; }
        public abstract int HighCounter { get; set; }
        public abstract string Name { get; set; }

        public abstract double CalculateSquare();
        public abstract double CalculatePerimeter();
        public abstract void Draw();
    }
}