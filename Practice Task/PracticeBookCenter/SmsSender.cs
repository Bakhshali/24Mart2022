using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeBookCenter
{
    class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("2.Send message by sms");
        }
    }
}
