namespace DeliveryOrderProcessorAzFunc
{
    public class OrderItem
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Units { get; set; }

        public OrderItem(string productName, decimal unitPrice, int units)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            Units = units;
        }
    }
}