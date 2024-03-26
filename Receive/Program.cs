using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(
    queue: "lead-users-list",
    durable: false,
    exclusive: false,
    autoDelete: true,
    arguments: null);

Console.WriteLine(value: " [*] Waiting for Messages. ");

var consumer = new EventingBasicConsumer(model: channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);

    Console.WriteLine(value: $" [x] Received: {message}");
};

channel.BasicConsume(
    queue: "lead-users-list", 
    autoAck: true, 
    consumer: consumer);

Console.WriteLine(value: " Press [enter] to exit. ");
Console.ReadLine();

