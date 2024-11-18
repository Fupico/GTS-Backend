using System.Threading.Tasks;

namespace MailConsumer.Mail {
    internal interface IEmailService {
        Task SendEmailAsync( string email, string subject, string message );

    }
}