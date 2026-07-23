using Confluent.Kafka;

var clientId = Guid.NewGuid().ToString();

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = $"chat-client-{clientId}",
    AutoOffsetReset = AutoOffsetReset.Latest
};

using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

consumer.Subscribe("chat-topic");

Console.WriteLine("Kafka Chat Consumer");
Console.WriteLine($"Client ID: {clientId}");
Console.WriteLine("Waiting for new chat messages...");
Console.WriteLine("Press Ctrl+C to stop.");

try
{
    while (true)
    {
        var result = consumer.Consume();

        Console.WriteLine($"Received: {result.Message.Value}");
    }
}
catch (OperationCanceledException)
{
    consumer.Close();
}
