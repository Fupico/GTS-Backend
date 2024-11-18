using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MailConsumer.Mail {
    public class SmtpEmailService : IEmailService {
        public async Task SendEmailAsync( string email, string subject, string message ) {

            //Mail Yapılandırması yapılacak
            using ( var client = new SmtpClient( "smtp.gmail.com" ) ) {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential( "emailata8@gmail.com", "hcom *** *** *** ***" );
                client.Port = 587;
                client.EnableSsl = true;
                var mailMessage = new MailMessage {
                    From = new MailAddress( "emailata8@gmail.com" ),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true
                };
                mailMessage.To.Add( email );
                await client.SendMailAsync( mailMessage );
            }
        }
    }
}
