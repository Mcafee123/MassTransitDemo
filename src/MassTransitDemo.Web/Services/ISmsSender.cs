using System.Threading.Tasks;

namespace RabbitMqDemo.Web.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
