using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory { HostName = "localhost" };
var connection = factory.CreateConnection();

using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "lead-users-list",
                     durable: false,
                     exclusive: false,
                     autoDelete: true,
                     arguments: null);

Console.WriteLine(value: "type a message and press <ENTER>");

while (true)
{
    string message = Console.ReadLine();

    if (message == "") break;

    var body = Encoding.UTF8.GetBytes(message);

    channel.BasicPublish(
        exchange: string.Empty,
        routingKey: "lead-users-list",
        basicProperties: null,
        body: body);

    Console.WriteLine(value: $" [x] Message -> {message}, Sent!");
}
