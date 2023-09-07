using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace DeliveryOrderProcessorAzFunc
{
    public class DeliveryOrderProcessorFunc
    {
        private readonly ILogger _logger;

        public DeliveryOrderProcessorFunc(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<DeliveryOrderProcessorFunc>();
        }

        [Function("DeliveryOrderProcessorFunc")]
        public async Task<CosmosDbRecord> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            var order = await JsonSerializer.DeserializeAsync<Order>(req.Body);
            return new CosmosDbRecord { Order = order };
        }
    }
}
