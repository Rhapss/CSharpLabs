using System;

namespace Chat
{
    public class Message
    {
        public User Initiator { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Data { get; set; }
    }
}
