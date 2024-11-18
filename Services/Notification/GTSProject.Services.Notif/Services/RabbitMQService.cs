using RabbitMQ.Client;
using System.Text;
using System.Threading.Channels;

namespace GTSProject.Services.Notif.Services {
    public class RabbitMQService : IDisposable {
        private readonly IConnection _connection;
        private IModel _channel;

        public RabbitMQService( ConnectionFactory factory ) {
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
        }

        public void Dispose() {
            _channel?.Close();
            _connection?.Close();
        }

        public void Publish( string exchangeName, string message, string user, string type ) {
            byte[] bytemessage = Encoding.UTF8.GetBytes( message );
            _channel.ExchangeDeclare( "ex", type: ExchangeType.Topic );

          

            IBasicProperties properties = _channel.CreateBasicProperties();
            properties.Persistent = true;

            _channel.BasicPublish(
                            exchange: exchangeName,
                            routingKey: $"{user}.{type}",
                            basicProperties: properties,
                            body: bytemessage
                        );

            _channel.QueueDeclare( queue: type, durable: false, exclusive: false, autoDelete: false );
            _channel.QueueBind( queue: type, exchange: exchangeName, routingKey: $"{user}.{type}" );

        }
    }
}
