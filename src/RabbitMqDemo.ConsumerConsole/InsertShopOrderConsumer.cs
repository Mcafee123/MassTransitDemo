using System;
using System.Threading.Tasks;
using RabbitMqDemo.Core.Contracts;

namespace RabbitMqDemo.ConsumerConsole
{
    /*
    public class InsertShopOrderConsumer : IConsumer<IInsertShopOrder>
    {
        public async Task Consume(ConsumeContext<IInsertShopOrder> context)
        {
            if (context.Message.CustomerFirstName.ToLower() == "fritz")
            {
                await Console.Out.WriteLineAsync(
                    $"Message not Accepted, because it's Fritz: {context.Message.CustomerFirstName} {context.Message.CustomerName}");
                context.NotifyFaulted();
            }
            else
            {
                await Console.Out.WriteLineAsync(
                    $"Updating customer: {context.Message.CustomerFirstName} {context.Message.CustomerName}");
            }
        }
    }*/
}