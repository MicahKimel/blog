using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace blog.Code
{
    public static class Email
    {
        public static void SendEmails(string toEmail)
        {
            // Email Host
            var smtpClient = new SmtpClient("smtp.office365.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("", ""),
                EnableSsl = true,
            };
            string reciepent = toEmail;
            var mailMessage = new MailMessage
            {
                From = new MailAddress("fromemail"),
                Subject = "Test",
                Body = $@"<h1>Hello this is the email</h1>",
                IsBodyHtml = true,
            };
            //mailMessage.Attachments.Add(new Attachment(path));
            mailMessage.To.Add(reciepent);
            smtpClient.Send(mailMessage);
        }
    }
}