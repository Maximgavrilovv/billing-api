using Billing.Models.Request;
using Task_billing_API.Models;

namespace Task_billing_API.Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderResponse> ProcessOrder(OrderRequest request);
    }
}
