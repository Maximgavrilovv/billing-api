namespace Task_billing_API.Models
{
    public class OrderResponse
    {
        public OrderResponse(long orderNumber, object? receipt)
        {
            OrderNumber = orderNumber;
            Receipt = receipt;
        }

        public OrderResponse(long orderNumber) : this(orderNumber, null) { }

        public long OrderNumber { get; init; }

        public object? Receipt { get; init; }
    }
}
