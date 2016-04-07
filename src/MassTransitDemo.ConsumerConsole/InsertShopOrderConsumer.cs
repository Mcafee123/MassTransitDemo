using System;
using System.Threading.Tasks;
using MassTransit;
using MassTransitDemo.Core.Contracts;

namespace MassTransitDemo.ConsumerConsole
{
    public class InsertShopOrderConsumer : IConsumer<IInsertShopOrder>
    {
        public async Task Consume(ConsumeContext<IInsertShopOrder> context)
        {
            await
                Console.Out.WriteLineAsync(
                    $"Updating customer: {context.Message.CustomerFirstName} {context.Message.CustomerName}");
        }
    }
}