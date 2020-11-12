
using System;

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
        public string CarModel { get; private set; }
        public string Color { get; private set; }
        public double Speed{ get; private set; }
        public int YearOfIssue{ get; private set; }
        
    }
}