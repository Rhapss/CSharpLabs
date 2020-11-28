using System;
using System.Collections.Generic;

namespace Lab8._2
{
    internal class DiscPhone
    {
        public DiscPhone()
        {
        }

        public DiscPhone(string phoneNum)
        {
            PhoneNum = phoneNum;
        }

        public string PhoneNum { get; set; }

        public virtual List<char> AllowedSymbs => new List<char>
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        protected string EnterNumber()
        {
            Console.Write("Введите номер абонента: ");
            while (true)
            {
                var invalid = false;
                PhoneNum = Console.ReadLine();
                if (PhoneNum != null)
                {
                    foreach (var symbol in PhoneNum)
                        if (!AllowedSymbs.Contains(symbol))
                        {
                            invalid = true;
                            break;
                        }

                    if (invalid)
                    {
                        Console.Write("Некорректный ввод. Попробуйте снова: ");
                        continue;
                    }

                    return PhoneNum;
                }

                Console.Write("Некорректный ввод. Попробуйте снова: ");
            }
        }

        public virtual void Call()
        {
            Console.WriteLine($"Вызов номерa {EnterNumber()}");
        }

        public virtual void TakeCall(string callingNum)
        {
            Console.WriteLine("Входящий вызов");
        }
    }
}