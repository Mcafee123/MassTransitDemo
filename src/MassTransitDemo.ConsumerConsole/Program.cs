using System;
using System.Threading;
using MassTransit;

namespace MassTransitDemo.ConsumerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri("rabbitmq://localhost/iba_orders"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                cfg.ReceiveEndpoint(host, "iba_orders_queue", e =>
                {
                    e.Consumer<InsertShopOrderConsumer>();
                });
            });

            busControl.Start();

            Console.WriteLine("Console waiting for InsertShopOrder Messages....");
            Console.ReadKey();

            busControl.Stop();
            Console.WriteLine("...bye");
            Thread.Sleep(300);
        }
    }
}
