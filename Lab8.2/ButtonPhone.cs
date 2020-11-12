using System;
using System.Collections.Generic;

namespace Lab8._2
{
    class ButtonPhone : DiscPhone
    {
        public ButtonPhone(string phoneNum) : base(phoneNum)
        {
            
        }
        public override List<char> AllowedSymbs => new List<char>()
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#'
        };
        public override void TakeCall(string callingNum)
        {
            Console.WriteLine($"Входящий вызов от {callingNum}");
        }
    }
}