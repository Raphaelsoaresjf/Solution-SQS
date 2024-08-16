using System;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Consumidor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Opa");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new ReceiveMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/583539974430/Teste_SQS"
            };
            var response = await client.ReceiveMessageAsync(request);

            foreach (var message in response.Messages) 
            { 
                Console.WriteLine($"{message}");
            }

        }
    }
}
