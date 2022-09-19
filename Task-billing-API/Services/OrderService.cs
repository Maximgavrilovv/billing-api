using Billing.Models.Request;
using Task_billing_API.Models;
using Task_billing_API.Services.Enums;
using Task_billing_API.Services.Interfaces;

namespace Task_billing_API.Services
{
    public class OrderService : IOrderService
    {

        public async Task<OrderResponse> ProcessOrder(OrderRequest request)
        {
            var gatewayService = GetGatewayService(request.GatewayId);

            var response = await gatewayService.SendOrder(request);
            return new OrderResponse(request.OrderNumber, response);
        }

        public IGatewayService? GetGatewayService(int paymentGateway)
        {
            if (paymentGateway == (int)PaymentGatewayEnum.CreditCard)
            {
                return new FakeCreditCardGatewayService();
            }
            if (paymentGateway == (int)PaymentGatewayEnum.PayPal)
            {
                return new FakePayPalGatewayService();
            }
            return new FakeDummyGatewayService();
        }
    }
}
