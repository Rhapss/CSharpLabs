using System;

namespace Lab8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var garage1 = new Garage();
            garage1.AddCar("Audi RS6", "Red", 305, 2020);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в ваш гараж, что хотите сделать?");
                Console.WriteLine(
                    "1)Вывести список автомобилей\n" +
                    "2)Добавить автомобиль\n" +
                    "3)Убрать автомобиль\n" +
                    "4)Прокатиться на автомобиле!\n" +
                    "5)Выход\n");
                int input;

                while (!int.TryParse(Console.ReadLine(), out input) || input < 0 || input > 5)
                    Console.Write("Некорректный ввод. Попробуйте снова: ");
                switch (input)
                {
                    //Показать автомобили
                    case 1:
                        Console.Clear();
                        garage1.ShowCars();
                        Console.ReadKey();
                        break;

                    //Добавить автомобиль
                    case 2:
                        Console.Clear();
                        string carModel, color;
                        float speed;
                        int yearOfIssue;
                        Console.Write("Введите марку автомобиля: ");
                        while (true)
                        {
                            carModel = Console.ReadLine();
                            if (string.IsNullOrEmpty(carModel))
                                Console.Write("Некорректный ввод. Попробуйте снова: ");
                            else break;
                        }

                        Console.Write("Введите цвет машины: ");
                        while (true)
                        {
                            color = Console.ReadLine();
                            if (string.IsNullOrEmpty(color))
                                Console.Write("Некорректный ввод. Попробуйте снова: ");
                            else break;
                        }

                        Console.Write("Введите скорость машины: ");
                        while (!float.TryParse(Console.ReadLine(), out speed) || speed <= 0)
                            Console.Write(
                                "Некорректный ввод. Скорость не может быть равна или меньше 0. Попробуйте снова: ");

                        Console.Write("Введите год выпуска машины: ");
                        while (!int.TryParse(Console.ReadLine(), out yearOfIssue) || yearOfIssue <= 0)
                            Console.Write(
                                "Некорректный ввод. Год выпуска не может быть равен или меньшим 0. Попробуйте снова: ");

                        garage1.AddCar(carModel, color, speed, yearOfIssue);
                        break;
                    //Удалить автомобиль
                    case 3:
                        Console.Clear();

                        if (garage1.CountCars() > 1)
                        {
                            int lowInput;
                            Console.WriteLine("Какой из автомобилей хотите убрать из гаража?");
                            garage1.ShowCars();

                            while (!int.TryParse(Console.ReadLine(), out lowInput) || lowInput <= 0 ||
                                   lowInput > garage1.CountCars())
                                Console.Write("Некорректный ввод. Попробуйте снова: ");
                            garage1.DeleteCar(lowInput);
                        }
                        else
                        {
                            garage1.DeleteCar(0);
                        }

                        break;
                    //Выехать на автомобиле
                    case 4:
                        if (garage1.CountCars() > 1)
                        {
                            int lowInput;
                            Console.WriteLine("На чём прокатимся?");
                            garage1.ShowCars();

                            while (!int.TryParse(Console.ReadLine(), out lowInput) || lowInput <= 0 ||
                                   lowInput > garage1.CountCars())
                                Console.Write("Некорректный ввод. Попробуйте снова: ");
                            garage1.RideCar(lowInput);
                        }
                        else
                        {
                            garage1.RideCar(0);
                        }

                        break;
                    case 5:
                        break;
                }

                if (input == 5) break;
            }
        }
    }
}