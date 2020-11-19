using System;

namespace Exam1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input;
            Cars carShop = new Cars();
            
            carShop.AddCar("Nissan Skyline GT-R R34", "white black spacegray yellow forrestgreen", 1989, 49_999, 280);
            carShop.AddCar("Honda NSX", "gray red yellow skyblue forrestgreen", 1990, 111_000, 274);
            carShop.AddCar("Toyota Supra A80", "orange white black red gray", 1997, 35_999, 330);
            carShop.AddCar("Mazda RX-7", "gray white black", 1993, 23_999, 265);
            carShop.AddCar("Subaru Impreza WRX STI", "blue, white, black", 2003, 16_999, 280);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Найти автомобиль по:\n" +
                                  "1)Названию\n" +
                                  "2)Цветовой палитре\n" +
                                  "3)Году выпуска\n" +
                                  "4)Цене\n" +
                                  "5)Мощности\n" +
                                  "6)По всем параметрам");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                case 1:
                    Console.Write("Введите полное или частичное название автомобиля: ");
                    carShop.SearchCarByName(Console.ReadLine());
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("Введите цвета цветовой палитры: ");
                    carShop.SearchCarByColors(Console.ReadLine());
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Введите год выпуска: ");
                    carShop.SearchCarByYear(Convert.ToUInt16(Console.ReadLine()));
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Введите цену автомобиля: ");
                    carShop.SearchCarByPrice(Convert.ToInt32(Console.ReadLine()));
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Введите мощность автомобиля: ");
                    carShop.SearchCarByHorses(Convert.ToUInt16(Console.ReadLine()));
                    Console.ReadKey();
                    break;
                case 6:
                {
                    Console.WriteLine("Введите параметры");
                    Console.Write("Название автомобиля: ");
                    string name = Console.ReadLine();
                    Console.Write("\nЦветовая палитра: ");
                    string colorCollection = Console.ReadLine();
                    Console.Write("\nГод выпуска: ");
                    ushort year = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("\nЦена: ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nМощность: ");
                    ushort hp = Convert.ToUInt16(Console.ReadLine());

                    carShop.SearchCar(name, colorCollection, year, price, hp);
                }
                    break;
                }
            }
        }
    }
}