using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using RabbitMQ.Client;

namespace RabbitMqDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // according to: https://www.rabbitmq.com/dotnet-api-guide.html

            // user
            const string userName = "iba";
            const string userPassword = "iba";

            // rabbitmq
            const string hostName = "localhost";
            const string virtualHostName = "iba";
            const string exchangeName = "iba_xchange";
            const string queueName = "iba_erp_queue";
            const bool ibaQueueIsDurable = true;
            const string ibaRoutingKey = "erp";

            // add a new virtual host "iba" to rabbitmq
            // -> RabbitMQ Management Dashboard: http://localhost:15672/

            // add a new user and set permissions for virtual host "iba
            // -> RabbitMQ Management Dashboard: http://localhost:15672/
            // -> do not forget to add the guest-user to the new virtual 
            // host or log in as "iba" to see the queue and the messages 
            // in the RabbitMq Management Dashboard.

            // create connection
            ConnectionFactory factory = new ConnectionFactory
            {
                UserName = userName,
                Password = userPassword,
                HostName = hostName,
                VirtualHost = virtualHostName
            };

            using (IConnection conn = factory.CreateConnection())
            {
                // create a "channel"
                using (IModel channel = conn.CreateModel())
                {
                    channel.ExchangeDeclare(exchangeName, ExchangeType.Direct);
                    channel.QueueDeclare(queueName, ibaQueueIsDurable, false, false, null);
                    channel.QueueBind(queueName, exchangeName, ibaRoutingKey, null);

                    byte[] messageBodyBytes = System.Text.Encoding.UTF8.GetBytes("Hello, world!");

                    IBasicProperties props = channel.CreateBasicProperties();
                    props.ContentType = "application/json";
                    props.ContentEncoding = "UTF-8";
                    props.DeliveryMode = 2; // Non-persistent (1) or persistent (2).
                    props.MessageId = Guid.NewGuid().ToString();
                    var unixTime = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                    props.Timestamp = new AmqpTimestamp(unixTime);
                    props.CorrelationId = "12345";
                    props.Priority = 4;
                    props.Headers = new Dictionary<string, object> {{"customHeader", "auftrags-id"}};

                    channel.BasicPublish(exchangeName,
                                       ibaRoutingKey, props,
                                       messageBodyBytes);
                }
            }
            Console.WriteLine((long) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
