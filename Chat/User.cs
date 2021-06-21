using System;
using System.Collections.Generic;

namespace Chat
{
    public class User
    {
        public string Username { get; }

        public event MessageHandler OnSent;
        public event MessageHandler OnReceived;

        private List<Message> History { get; } = new List<Message>();

        public User(string name) => Username = name;

        public void Send(string data)
        {
            var newMessage = new Message { Data = data, Initiator = this, TimeStamp = DateTime.Now };
            History.Add(newMessage);
            OnSent?.Invoke(newMessage);
        }

        public void Receive(Message message)
        {
            History.Add(message);
            OnReceived?.Invoke(message);
        }
    }
}
