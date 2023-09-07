using Microsoft.Azure.Functions.Worker;

namespace DeliveryOrderProcessorAzFunc
{
    public class CosmosDbRecord
    {
        [CosmosDBOutput("cosmos-order-db", "eshop-webapp",
            ConnectionStringSetting = "CosmosDbConnectionString", CreateIfNotExists = true)]
        public Order Order { get; set; }
    }
}
