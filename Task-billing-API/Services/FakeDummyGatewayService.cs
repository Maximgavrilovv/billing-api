using Billing.Models.Request;
using Task_billing_API.Services.Interfaces;

namespace Task_billing_API.Services
{
    public class FakeDummyGatewayService : IGatewayService
    {
        public async Task<string> SendOrder(OrderRequest orderRequest)
        {
            Console.WriteLine($"No gateway service found");
            await Task.Delay(5000);

            return $"Payment for order with number {orderRequest.OrderNumber} in amount: {orderRequest.PaymentAmount} was not sent. No gateway service found";
        }
    }
}
