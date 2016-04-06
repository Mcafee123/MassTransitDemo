using System;
using System.Threading.Tasks;
using MassTransit;
using MassTransitDemo.Core.Contracts;

namespace MassTransitDemo.ConsumerConsole
{
    public class InsertShopOrderConsumer : IConsumer<InsertShopOrder>
    {
        public async Task Consume(ConsumeContext<InsertShopOrder> context)
        {
            await
                Console.Out.WriteLineAsync(
                    $"Updating customer: {context.Message.CustomerFirstName} {context.Message.CustomerName}");
        }
    }
}