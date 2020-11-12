using System;

namespace Lab8._2
{
    class SmartPhone : ColorfulPhone
    {
        public SmartPhone(string phoneNum, int screenWidth, int screenHeight, int screenResolution, string phoneColor,
            int colorAmount, bool isTwoSim, bool touchScreen, int touchCounter, int cameraQuantity, string secondPhoneNumber) 
            : base(phoneNum, screenWidth, screenHeight, screenResolution, phoneColor, colorAmount, isTwoSim, secondPhoneNumber)
        {
            
        }
        public bool TouchScreen { get; set; }
        public int TouchCounter { get; set; }
        public int CameraQuantity { get; set; }

        public void TakePhoto()
        {
            Console.WriteLine($"Сделано фото.");
        }
        public void RecordVideo()
        {
            Console.WriteLine($"Записано видео.");
        }
    }
}