using System;
using System.Collections.Generic;

namespace Exam1
{
    class Cars : Car
    {
        List<Car> CarCollection = new List<Car>();

        public void AddCar(string name, string colorCollection, ushort year, int price, ushort horsePower)
        {
            CarCollection.Add(new Car(name, colorCollection, year, price, horsePower));
        }

        public void SearchCarByName(string name)
        {
            
            List<Car> findedCars = new List<Car>();
            for (int i = 0; i < CarCollection.Count; i++)
            {
                CarCollection[i].Name = CarCollection[i].Name.ToLower();
                if (CarCollection[i].Name.Contains(name.ToLower()))
                {
                    findedCars.Add(CarCollection[i]);
                }
            }
            if (findedCars.Count != 0)
            {
                Console.WriteLine($"Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                {
                    Console.WriteLine($"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
                }
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }
        public void SearchCarByColors(string colorCollection)
        {
            
            List<Car> findedCars = new List<Car>();
            for (int i = 0; i < CarCollection.Count; i++)
            {    
                CarCollection[i].ColorCollection = CarCollection[i].ColorCollection.ToLower();
                if (CarCollection[i].ColorCollection.Contains(colorCollection.ToLower()))
                {
                    findedCars.Add(CarCollection[i]);
                }
            }
            if (findedCars.Count != 0)
            {
                Console.WriteLine($"Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                {
                    Console.WriteLine($"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
                }
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }
        public void SearchCarByYear(ushort year)
        {
            List<Car> findedCars = new List<Car>();
            for (int i = 0; i < CarCollection.Count; i++)
            {
                if (CarCollection[i].Year.Equals(year))
                {
                    findedCars.Add(CarCollection[i]);
                }
            }
            if (findedCars.Count != 0)
            {
                Console.WriteLine($"Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                {
                    Console.WriteLine($"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
                }
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }
        public void SearchCarByPrice(int price)
        {
            List<Car> findedCars = new List<Car>();
            for (int i = 0; i < CarCollection.Count; i++)
            {
                if (CarCollection[i].Price.Equals(price))
                {
                    findedCars.Add(CarCollection[i]);
                }
            }
            if (findedCars.Count != 0)
            {
                Console.WriteLine($"Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                {
                    Console.WriteLine($"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
                }
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }
        public void SearchCarByHorses(ushort horsePower)
        {
            List<Car> findedCars = new List<Car>();
            for (int i = 0; i < CarCollection.Count; i++)
            {
                if (CarCollection[i].HorsePower.Equals(horsePower))
                {
                    findedCars.Add(CarCollection[i]);
                }
            }

            if (findedCars.Count != 0)
            {
                Console.WriteLine($"Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                {
                    Console.WriteLine($"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
                }
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
            
        }
        public void SearchCar(string name, string colorCollection, ushort year, int price, ushort hp)
        {
            List<Car> findedCars = new List<Car>();
            for (int i = 0; i < CarCollection.Count; i++)
            {
                if (CarCollection[i].Name.Contains(name.ToLower()) &&
                    CarCollection[i].ColorCollection.Contains(colorCollection.ToLower()) &&
                    CarCollection[i].Year.Equals(year) && 
                    CarCollection[i].Price.Equals(price) &&
                    CarCollection[i].HorsePower.Equals(hp))
                {
                    findedCars.Add(CarCollection[i]);
                }
            }
            if (findedCars.Count != 0)
            {
                Console.WriteLine($"Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                {
                    Console.WriteLine($"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
                }
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }
    }
}