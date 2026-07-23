# Kafka Chat Application

## Overview

This project demonstrates Apache Kafka integration with C# using the Confluent.Kafka .NET client.

## Components

- **KafkaChatProducer** - Publishes chat messages to the Kafka topic `chat-topic`.
- **KafkaChatConsumer** - Consumes and displays messages from `chat-topic`.

## Technologies

- .NET 8
- C#
- Apache Kafka
- Confluent.Kafka
- Docker

## Kafka Setup

Kafka is hosted using the Apache Kafka Docker image and exposed on port `9092`.

Create the topic:

```bash
docker exec kafka /opt/kafka/bin/kafka-topics.sh \
  --create \
  --topic chat-topic \
  --bootstrap-server localhost:9092 \
  --partitions 1 \
  --replication-factor 1
