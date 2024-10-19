using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_02
{
    public delegate void SendEmailHandler (string email, string message);

    internal class NotificationService
    {
        public SendEmailHandler SendEmail;

        public NotificationService(SendEmailHandler sendEmail)
        {
            SendEmail = sendEmail;
        }

        public void SendEmailNotification(string email, string message)
        {
            SendEmail(email, message);
        }
    }
}
