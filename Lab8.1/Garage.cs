using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class Garage : Car
    {
        private List<Car> cars;
        public Garage()
        {
            cars = new List<Car>();    
        }
        

        public void AddCar(string carModel, string color, double speed, int yearOfIssue)
        {
            var car = new Car(carModel, color, speed, yearOfIssue);
            cars.Add(car);
        }

        public void ShowCars()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("Ваш гараж пуст!");
            }
            else
            {
                int i = 1;
                foreach (var car in cars)
                {
                    Console.WriteLine($"{i})Model: {car.CarModel}, Color {car.Color}, " +
                                      $"Max Speed: {car.Speed}km/h, Year of Issue {car.YearOfIssue}");
                    i++;
                } 
            }
            
        }

        public void DeleteCar(int index)
        {
            // cars.RemoveAll(c => 
            //     c.CarModel == carModel && 
            //     c.Color == color && 
            //     c.Speed == speed && 
            //     c.YearOfIssue == yearOfIssue);
            cars.Remove(cars.ElementAt(index - 1));
        }

        public void RideCar(int index)
        {
            Console.Clear();
            var currentCar = cars[index - 1];
            Console.WriteLine($"Хорошо прокатиться на " +
                              $"{currentCar.Color} {currentCar.CarModel} {currentCar.YearOfIssue}" +
                              $" года выпуска");
            Console.ReadKey();
        }

        public int CountCars()
        {
            int counter = 0;
            foreach (var car in cars)
                counter++;
            return counter;
        }
    }
}