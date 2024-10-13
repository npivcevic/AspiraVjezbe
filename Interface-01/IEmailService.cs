using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_01
{
    internal interface IEmailService
    {
        public void SendEmail(string email, string message);
    }
}
