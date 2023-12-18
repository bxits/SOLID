using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class EMailAlertErrorLogger : IErrorLogger
    {
        public bool ErrorLoggedSuccessful
        { 
            get;
            private set;
        }

        public void Log(string message)
        {
            SmtpClient cl = new SmtpClient("mail.its-stuttgart.de");
            //.....
            cl.Send(
                new MailMessage(
                    from: "ruediger.berg@its-stuttgart.de",
                    to: "benedikt.alt@its-stuttgart.de",
                    subject: "Mal ein Hallo",
                    body: message)
                );
            ErrorLoggedSuccessful = true;
        }
    }
}
