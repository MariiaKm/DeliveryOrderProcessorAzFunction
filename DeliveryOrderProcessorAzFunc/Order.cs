namespace DeliveryOrderProcessorAzFunc
{
    public class Order
    {
        public List<OrderItem> OrderItems { get; set; }
        public Address ShipToAddress { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
