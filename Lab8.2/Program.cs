using System;

namespace Lab8._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Дисковый телефон:");
            var discPhone = new DiscPhone("111");

            Console.Write("Доступные символы: ");
            foreach (var sym in discPhone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {discPhone.PhoneNum}");
            discPhone.Call();
            discPhone.TakeCall("101");

            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Кнопочный телефон:");
            var bPhone = new ButtonPhone("222");

            Console.Write("Доступные символы: ");
            foreach (var sym in bPhone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {bPhone.PhoneNum}");
            bPhone.Call();
            bPhone.TakeCall("101");

            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Телефон с черно-белым экраном:");
            var colorlessPhone = new ColorlessPhone("333", 50, 100, 2, "Черный");

            Console.Write("Доступные символы: ");
            foreach (var sym in colorlessPhone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {colorlessPhone.PhoneNum}");
            Console.WriteLine($"Ширина экрана (пиксели): {colorlessPhone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {colorlessPhone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {colorlessPhone.ScreenResolution}");
            Console.WriteLine($"Цвет телефона: {colorlessPhone.PhoneColor}");
            colorlessPhone.Call();
            colorlessPhone.TakeCall("101");
            colorlessPhone.SendSms("Привет, друг", "068");
            colorlessPhone.GetSms("Шабат шалом", "101");


            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Телефон с цветным экраном:");
            var colorPhone = new ColorfulPhone("444", 200, 400, 5, "Черный", 16000000, true, "66666");

            Console.Write("Доступные символы: ");
            foreach (var sym in colorPhone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {colorPhone.PhoneNum}");
            Console.WriteLine($"Ширина экрана (пиксели): {colorPhone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {colorPhone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {colorPhone.ScreenResolution}");
            Console.WriteLine($"Цвет телефона: {colorPhone.PhoneColor}");
            Console.WriteLine($"Количество сим-карт: {(colorPhone.IsTwoSim ? 2 : 1)}");
            Console.WriteLine($"Второй номер: {(colorPhone.IsTwoSim ? colorPhone.SecondPhoneNumber : "-")}");
            colorPhone.Call();
            colorPhone.TakeCall("101");
            colorPhone.SendSms("Привет, друг", "068");
            colorPhone.GetSms("Шабат шалом", "101");
            colorPhone.SendMms("123123");
            colorPhone.GetMms("101");


            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Смартфон:");
            var smartphone = new SmartPhone("555", 1080, 1920,
                6, "Черный", 16777216, true,
                true, 10, 3, "102");

            Console.Write("Доступные символы: ");
            foreach (var sym in smartphone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Номер: {smartphone.PhoneNum}");
            Console.WriteLine($"Ширина экрана (пиксели): {smartphone.ScreenWidth}");
            Console.WriteLine($"Высота экрана (пиксели): {smartphone.ScreenHeight}");
            Console.WriteLine($"Размер экрана (дюймы): {smartphone.ScreenResolution}");
            Console.WriteLine($"Цвет телефона: {smartphone.PhoneColor}");
            Console.WriteLine($"Количество сим-карт: {(smartphone.IsTwoSim ? 2 : 1)}");
            Console.WriteLine($"Второй номер: {(smartphone.IsTwoSim ? smartphone.SecondPhoneNumber : "-")}");
            Console.WriteLine($"Сенсорный экран: {(smartphone.TouchScreen ? "да" : "нет")}");
            Console.WriteLine($"Максимальное количество касаний: {smartphone.TouchCounter}");
            Console.WriteLine($"Количество камер: {smartphone.CameraQuantity}");
            colorPhone.Call();
            colorPhone.TakeCall("101");
            colorPhone.SendSms("Привет, друг", "068");
            colorPhone.GetSms("Шабат шалом", "101");
            colorPhone.SendMms("123123");
            colorPhone.GetMms("101");
            smartphone.TakePhoto();
            smartphone.RecordVideo();

            Console.ReadLine();
        }
    }
}