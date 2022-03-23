using System;

namespace PracticeBookCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmailSender email = new EmailSender();
            email.SendMessage();

            SmsSender sms = new SmsSender();
            sms.SendMessage();

            Console.WriteLine("0.Quit");


            switch (Convert.ToInt32(Console.ReadLine())
                )
            {
                case 1:
                    Console.WriteLine("Email ile mesaj gonderilmelidir");
                    break;
                case 2:
                    Console.WriteLine("Sms ile mesaj gonderilmelidir");
                    break;
                case 0:
                    break;
            }
        }
    }
}

