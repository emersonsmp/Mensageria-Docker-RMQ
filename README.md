# Mensageria Docker e RabbitMQ
A simple example to help you with your first contact with messaging using RabbitMQ.

Download docker: [Here](https://www.docker.com/products/docker-desktop/)

Docker Command to create and execute a RabbitMQ Container:
```
docker run -d --hostname rmq --name rmq-server -p 8080:15672 -p 5672:5672 rabbitmq:3.12-management
```
You can acess RabbitMQ from your Localhost, in this case: http://localhost:8080/
</br>Use the user and pass "guest" for your first autentication.

Use the Send and Receive in this Repository.

Official documentation [Here](https://www.rabbitmq.com/tutorials/tutorial-one-dotnet)
