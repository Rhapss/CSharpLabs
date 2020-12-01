using System;
using System.Collections.Generic;

namespace Exam1
{
    internal class Cars : Car
    {
        private readonly List<Car> _carCollection = new List<Car>();

        public void AddCar(string name, string colorCollection, ushort year, int price, ushort horsePower)
        {
            _carCollection.Add(new Car(name, colorCollection, year, price, horsePower));
        }

        public void SearchCarByName(string name)
        {
            var findedCars = new List<Car>();
            for (var i = 0; i < _carCollection.Count; i++)
            {
                _carCollection[i].Name = _carCollection[i].Name.ToLower();
                if (_carCollection[i].Name.Contains(name.ToLower())) findedCars.Add(_carCollection[i]);
            }

            if (findedCars.Count != 0)
            {
                Console.WriteLine("Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                    Console.WriteLine(
                        $"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }

        public void SearchCarByColors(string colorCollection)
        {
            var findedCars = new List<Car>();
            for (var i = 0; i < _carCollection.Count; i++)
            {
                _carCollection[i].ColorCollection = _carCollection[i].ColorCollection.ToLower();
                if (_carCollection[i].ColorCollection.Contains(colorCollection.ToLower()))
                    findedCars.Add(_carCollection[i]);
            }

            if (findedCars.Count != 0)
            {
                Console.WriteLine("Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                    Console.WriteLine(
                        $"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }

        public void SearchCarByYear(ushort year)
        {
            var findedCars = new List<Car>();
            for (var i = 0; i < _carCollection.Count; i++)
                if (_carCollection[i].Year.Equals(year))
                    findedCars.Add(_carCollection[i]);
            if (findedCars.Count != 0)
            {
                Console.WriteLine("Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                    Console.WriteLine(
                        $"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }

        public void SearchCarByPrice(int price)
        {
            var findedCars = new List<Car>();
            for (var i = 0; i < _carCollection.Count; i++)
                if (_carCollection[i].Price.Equals(price))
                    findedCars.Add(_carCollection[i]);
            if (findedCars.Count != 0)
            {
                Console.WriteLine("Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                    Console.WriteLine(
                        $"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }

        public void SearchCarByHorses(ushort horsePower)
        {
            var findedCars = new List<Car>();
            for (var i = 0; i < _carCollection.Count; i++)
                if (_carCollection[i].HorsePower.Equals(horsePower))
                    findedCars.Add(_carCollection[i]);

            if (findedCars.Count != 0)
            {
                Console.WriteLine("Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                    Console.WriteLine(
                        $"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }

        public void SearchCar(string name, string colorCollection, ushort year, int price, ushort hp)
        {
            var findedCars = new List<Car>();
            for (var i = 0; i < _carCollection.Count; i++)
                if (_carCollection[i].Name.Contains(name.ToLower()) &&
                    _carCollection[i].ColorCollection.Contains(colorCollection.ToLower()) &&
                    _carCollection[i].Year.Equals(year) &&
                    _carCollection[i].Price.Equals(price) &&
                    _carCollection[i].HorsePower.Equals(hp))
                    findedCars.Add(_carCollection[i]);
            if (findedCars.Count != 0)
            {
                Console.WriteLine("Вы искали эти автомобили?:");
                foreach (var car in findedCars)
                    Console.WriteLine(
                        $"Model: {car.Name} | Colors: {car.ColorCollection} | Year:{car.Year} | Price: {car.Price} | HP: {car.HorsePower}");
            }
            else
            {
                Console.WriteLine("Не найдено автомобилей по вашему запросу");
            }
        }
    }
}