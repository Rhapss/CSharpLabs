using System;
using System.Collections.Generic;

namespace Lab8._2
{
    internal class ColorlessPhone : ButtonPhone
    {
        public ColorlessPhone(string phoneNum, int screenWidth, int screenHeight, int screenResolution,
            string phoneColor) : base(phoneNum)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            ScreenResolution = screenResolution;
            PhoneColor = phoneColor;
        }

        public override List<char> AllowedSymbs => new List<char>
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '+'
        };

        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public int ScreenResolution { get; set; }
        public string PhoneColor { get; set; }

        public void SendSms(string sms, string recipientNumber)
        {
            Console.WriteLine($"Абоненту {recipientNumber} отправлено сообщение \"{sms}\"");
        }

        public void GetSms(string sms, string senderNumber)
        {
            Console.WriteLine($"Получено сообщение: \"{sms}\" от {senderNumber}");
        }
    }
}