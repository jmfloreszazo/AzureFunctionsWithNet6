using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace azfServiceBusQueue
{
    public class Function1
    {
        [FunctionName("Function1")]
        public static void Run(
            [QueueTrigger("demoqueue", Connection = "ConnectToQueue")] string myQueueItem,
            ILogger log,
            [ServiceBus("demoqueue", Connection = "ConnectToServiceBus")] out string queueMessage)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            queueMessage = myQueueItem;
        }
    }
}
