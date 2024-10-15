using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    /* burada kapsayıcı NotificationService sınıfı daha alt bir sınıf olan EmailSender a bağlıdır. bu Dependency Inversion Principle  a uymayan bir yapıdır.
    public class NotificationService
    {
        private EmailSender emailSender = new EmailSender();

        public void SendNotification(string message)
        {
            emailSender.SendEmail(message);
        }
    }

    public class EmailSender
    {
        public void SendEmail(string message)
        {
            // Email gönderme işlemi
        }
    }
    */

    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email gönderildi: {message}");
        }
    }

    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS gönderildi: {message}");
        }
    }

    public class NotificationService //burada NotificationService direkt mail classından koparılıp kendi içinde ana interface IMessageSender a bağlanmıştır.
    {
        private IMessageSender messageSender;

        public NotificationService(IMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        public void SendNotification(string message)
        {
            messageSender.SendMessage(message);
        }
    }
}
