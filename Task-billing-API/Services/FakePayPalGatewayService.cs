using Billing.Models.Request;
using Task_billing_API.Services.Interfaces;

namespace Task_billing_API.Services
{
    public class FakePayPalGatewayService : IGatewayService
    {
        public async Task<string> SendOrder(OrderRequest orderRequest)
        {
            Console.WriteLine($"Sending order for order number {orderRequest.OrderNumber}");
            await Task.Delay(5000);

            return $"Payment for order with number {orderRequest.OrderNumber} was sent to Pay Pal. Payment amount: {orderRequest.PaymentAmount}";
        }
    }
}
