using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeBookCenter
{
    class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("1.Send message by Email");
        }
    }
}
