using Billing.Models.Request;

namespace Task_billing_API.Services.Interfaces
{
    public interface IGatewayService
    {
        public Task<string> SendOrder(OrderRequest orderRequest);
    }
}
