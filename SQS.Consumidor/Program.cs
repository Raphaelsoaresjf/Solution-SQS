using System;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var request = new ReceiveMessageRequest
{
    QueueUrl = "AWS_ENDPOINT_URL"
};
var response = await client.ReceiveMessageAsync(request);

foreach (var message in response.Messages)
{
    Console.WriteLine(message.Body);
    await client.DeleteMessageAsync("AWS_ENDPOINT_URL", message.ReceiptHandle);
}
