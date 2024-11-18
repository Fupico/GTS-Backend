using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace ConsumerTest {
    public class Program {

        static void Main( string[] args ) {

            var factory = new ConnectionFactory() {
                HostName = "octopus-01.rmq3.cloudamqp.com",
                UserName = "xnnwtwsl",
                Password = "ejRyVsRu810ucmWVMQ8E2DfhZZ7bZ10r",
                Port = int.Parse( "5672" ),
                VirtualHost = "xnnwtwsl"
            };

            var connection = factory.CreateConnection();
            IModel _channel = connection.CreateModel();
            var consumer = new EventingBasicConsumer( _channel );

            var exchange = "ex";//Lazım olursa diye exc i de bu şekilde tanımladım.
            Console.Write( "user : " );
            var user = Console.ReadLine();
            Console.Write( "Type : " );
            var type = Console.ReadLine();

            _channel.QueueDeclare( queue: type, durable: true, exclusive: false, autoDelete: false );
            /* queue -> Kuyruğumuzun adı
            * durable -> Eğer true yaparsak kuyruklarımız fiziksel,false yaparsak hafızada saklanır.
            * exclusive -> True sadece bu kanal, false farklı kanallar üzerinden de erişim demek Kuyruğumuza Consumer uygulaması üzerinden, yani farklı bir kanal üzerinden erişeceğimiz için false yapmalıyız.
            *autoDelete ->Kuyrukta yer alan veri consumera ulaştığında silinmesi belirtilir. */


            _channel.QueueBind( queue: type, exchange: exchange, routingKey: $"{user}.#" );

            //*.*.c.* → route key’in üçüncü sırasında c olanları dinlemek için.
            //a.# → route key’in başında a olan ve gerisiyle ilgilenmediğim kuyrukları dinlemek için
            _channel.BasicConsume( type, autoAck: false, consumer: consumer );

            consumer.Received += ( sender, e ) => {
                try {
                    var message = Encoding.UTF8.GetString( e.Body.ToArray() );
                    Console.WriteLine( "Gelen Mesaj: " + message );
                    _channel.BasicAck( deliveryTag: e.DeliveryTag, multiple: false );
                }
                catch ( Exception ex ) {
                    Console.WriteLine( $"Hata: {ex.Message}" );
                }
            };
            Console.ReadKey();
        }
    }

}