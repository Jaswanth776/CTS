using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Kafka Chat Producer");
Console.WriteLine("Type a message and press Enter.");
Console.WriteLine("Type 'exit' to close the producer.");

while (true)
{
    Console.Write("You: ");
    var message = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(message))
        continue;

    if (message.Equals("exit", StringComparison.OrdinalIgnoreCase))
        break;

    try
    {
        var result = await producer.ProduceAsync(
            "chat-topic",
            new Message<Null, string>
            {
                Value = message
            });

        Console.WriteLine(
            $"Message sent to {result.TopicPartitionOffset}");
    }
    catch (ProduceException<Null, string> ex)
    {
        Console.WriteLine($"Delivery failed: {ex.Error.Reason}");
    }
}

producer.Flush(TimeSpan.FromSeconds(10));
