﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_01
{
    internal class EmailServiceSMTP : IEmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending email using SMTP to: {email} with content: {message}");
        }
    }
}
