using Billing.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Task_billing_API.Services.Interfaces;

namespace Task_billing_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillingController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public BillingController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("Order")]
        public async Task<IActionResult> Order(OrderRequest billingRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _orderService.ProcessOrder(billingRequest);
            return Ok(result);
        }
    }
}