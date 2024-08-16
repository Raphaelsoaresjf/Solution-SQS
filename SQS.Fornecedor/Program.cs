using System;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Fornecedor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Opa");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new SendMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/583539974430/Teste_SQS",
                MessageBody = "Teste envio"
            };

            await client.SendMessageAsync(request);
        }
    }
}
