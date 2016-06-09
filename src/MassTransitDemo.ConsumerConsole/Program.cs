using System;
using System.Threading;

namespace RabbitMqDemo.ConsumerConsole
{
    class Program
    {
        /*
        static IBusControl _busControl;

        static void Main(string[] args)
        {
            while (true)
            {
                if (_busControl == null)
                {
                    _busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
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

                    _busControl.Start();
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Console waiting for InsertShopOrder Messages.... (press Esc to exit)");

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    _busControl.Stop();
                    Console.WriteLine("...bye");
                    Thread.Sleep(300);
                    break;
                }
            }
        }
        */
    }
}
