﻿namespace DIP.Right
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}