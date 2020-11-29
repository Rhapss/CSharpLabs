namespace Lab9._1
{
    class Painter : IDraw
    {
        public Painter()
        {
            
        }

        public Painter(Shape shape)
        {
            Shape = shape;
        }
        
        public Shape Shape { get; set; }
        public void Draw()
        {
            Shape.Draw();
        }
    }
}