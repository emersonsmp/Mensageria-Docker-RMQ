# Mensageria Docker e RabbitMQ

Download docker: https://www.docker.com/products/docker-desktop/

Docker Command to create and execute a RabbitMQ Container:
```
docker run -d --hostname rmq --name rmq-server -p 8080:15672 -p 5672:5672 rabbitmq:3.12-management
```
Use the Send and Receive in this Repository
