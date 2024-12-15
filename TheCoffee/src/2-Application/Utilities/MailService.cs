using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace TheCoffee.src.Application.Utilities
{
    public class MailService : IEmailSender
    {
        public Task SendEmailAsync(string email,string subject, string message)
        {
            var mail = "";
            var pw = "";
            var client = new SmtpClient(mail, 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };
            return client.SendMailAsync(new MailMessage (
                from: mail,to:mail,subject,message));

        }
    }
}
