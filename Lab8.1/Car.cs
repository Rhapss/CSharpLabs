namespace Lab8
{
    public class Car
    {
        public Car()
        {
        }

        public Car(string carModel, string color, double speed, int yearOfIssue)
        {
            CarModel = carModel;
            Color = color;
            Speed = speed;
            YearOfIssue = yearOfIssue;
        }

        public string CarModel { get; }
        public string Color { get; }
        public double Speed { get; }
        public int YearOfIssue { get; }
    }
}