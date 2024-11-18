using MailConsumer.Mail;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MailConsumer {
    internal class Program {
        static void Main( string[] args ) {

                // RabbitMQ bağlantısı için ayarlar
                var factory = new ConnectionFactory() {
                    HostName = "octopus-01.rmq3.cloudamqp.com",
                    UserName = "xnnwtwsl",
                    Password = "ejRyVsRu810ucmWVMQ8E2DfhZZ7bZ10r",
                    Port = 5672,
                    VirtualHost = "xnnwtwsl"
                };

                // RabbitMQ bağlantısını ve kanalı oluştur
                var connection = factory.CreateConnection();
                var _channel = connection.CreateModel();

                // Exchange tanımlama
                const string exchangeName = "ex";
                _channel.ExchangeDeclare( exchange: exchangeName, type: ExchangeType.Topic );

                const string type = "Mail";

                // Queue tanımlama
                _channel.QueueDeclare(
                    queue: type,
                    durable: false,
                    exclusive: false,
                    autoDelete: false
                );

                // Queue ve routing key bağlama
                string routingKey = $"#.{type}";
                _channel.QueueBind(
                    queue: type,
                    exchange: exchangeName,
                    routingKey: routingKey
                );

                // Consumer için öncelik ayarları
                _channel.BasicQos( prefetchSize: 0, prefetchCount: 1, global: false );

                // Mesajları dinlemek için bir tüketici oluştur
                var consumer = new EventingBasicConsumer( _channel );
                consumer.Received += async ( sender, e ) => {
                    var messages = Encoding.UTF8.GetString( e.Body.ToArray() );
                    SmtpEmailService smtpEmailService = new SmtpEmailService();

                    //metinler- ile ayrıldığı varsayıldı
                    string patternMail = @"Email:\s*(.*?)-";
                    Match match = Regex.Match( messages, patternMail );
                    string Mail = match.Groups[1].Value.Trim();

                    string patternSubject = @"Subject:\s*(.*?)-";
                    Match match1 = Regex.Match( messages, patternSubject );
                    string subject = match.Groups[1].Value.Trim();

                    string keyword = "message:";
                    string message = messages.Substring( messages.IndexOf( keyword ) + keyword.Length ).Trim();
                    await smtpEmailService.SendEmailAsync( Mail, subject, message );

                    // Mesajın başarılı bir şekilde işlendiğini bildir
                    _channel.BasicAck( deliveryTag: e.DeliveryTag, multiple: false );
                    Console.WriteLine(message);
                };

                // Tüketici kuyruğa bağlanır
                _channel.BasicConsume(
                    queue: type,
                    autoAck: false, // Manuel onay için false
                    consumer: consumer
                );

                Console.WriteLine( $" [*] Waiting for messages for {routingKey}. Press [enter] to exit." );
                Console.ReadKey();
        }
    }
}
