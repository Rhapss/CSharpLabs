using System;

namespace Lab8._2
{
    internal class ColorfulPhone : ColorlessPhone
    {
        public ColorfulPhone(string phoneNum, int screenWidth, int screenHeight, int screenResolution,
            string phoneColor,
            int colorAmount, bool isTwoSim, string secondPhoneNumber = null)
            : base(phoneNum, screenWidth, screenHeight, screenResolution, phoneColor)
        {
            ColorAmount = colorAmount;
            IsTwoSim = isTwoSim;
            SecondPhoneNumber = secondPhoneNumber;
        }

        public int ColorAmount { get; set; }
        public bool IsTwoSim { get; set; }
        public string SecondPhoneNumber { get; set; }

        public void SendMms(string recipientNumber)
        {
            Console.WriteLine($"Абоненту {recipientNumber} отправлено MMS");
        }

        public void GetMms(string senderNumber)
        {
            Console.WriteLine($"Получено сообщение: MMS от {senderNumber}");
        }
    }
}