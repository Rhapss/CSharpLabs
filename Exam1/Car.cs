namespace Exam1
{
    class Car
    {
        public Car()
        {
            
        }
        public Car(string name, string colorCollection, ushort year, int price, ushort horsePower)
        {
            Name = name;
            ColorCollection = colorCollection;
            Year = year;
            Price = price;
            HorsePower = horsePower;
        }
        public string Name { get; set; }
        public string ColorCollection { get; set; }
        public ushort Year { get; set; }
        public int Price { get; set; }
        public ushort HorsePower { get; set; }
    }
}