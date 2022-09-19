using System.ComponentModel.DataAnnotations;

namespace Billing.Models.Request
{
    public class OrderRequest
    {
        public OrderRequest(long orderNumber, int userId, decimal paymentAmount, int gatewayId, string? description)
        {
            OrderNumber = orderNumber;
            UserId = userId;
            PaymentAmount = paymentAmount;
            GatewayId = gatewayId;
            Description = description;
        }

        [Required]
        public long OrderNumber { get; }

        [Required]
        public int UserId { get; }

        [Required]
        public decimal PaymentAmount { get; }

        [Required]
        public int GatewayId { get; }

        public string? Description { get; }
    }
}
