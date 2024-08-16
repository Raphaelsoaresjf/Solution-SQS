using System;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var request = new SendMessageRequest
{
    QueueUrl = "AWS_ENDPOINT_URL",
    MessageBody = "Teste envio"
};

await client.SendMessageAsync(request);
