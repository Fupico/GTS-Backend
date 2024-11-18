using GTSProject.Services.Notif.Services;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder( args );

// RabbitMQ baðlantýsýný yapýlandýrma iþlemi
builder.Services.AddSingleton<ConnectionFactory>( sp => {
    return new ConnectionFactory() {
        HostName = "octopus-01.rmq3.cloudamqp.com",
        UserName = "xnnwtwsl",
        Password = "ejRyVsRu810ucmWVMQ8E2DfhZZ7bZ10r",
        Port = int.Parse( "5672" ),
        VirtualHost = "xnnwtwsl"
    };
} );

// IConnection kaydý
builder.Services.AddSingleton<IConnection>( sp => {
    var factory = sp.GetRequiredService<ConnectionFactory>();
    return factory.CreateConnection();
} );

// RabbitMQService
builder.Services.AddScoped<RabbitMQService>();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() ) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
