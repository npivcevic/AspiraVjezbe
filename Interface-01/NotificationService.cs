using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_01
{
    internal class NotificationService
    {
        IEmailService emailService;

        public NotificationService(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void SendEmailNotification(string email, string message)
        {
            this.emailService.SendEmail(email, message);
        }
    }
}
