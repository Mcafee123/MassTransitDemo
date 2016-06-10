using System.Threading.Tasks;

namespace RabbitMqDemo.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
