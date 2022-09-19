using Billing.Models.Request;
using Task_billing_API.Services;
using Task_billing_API.Services.Interfaces;

namespace TestBillingApi
{
    [TestClass]
    public class BilllingApiTests
    {
        private IGatewayService _gatewayService;

        [TestInitialize]
        public void Init()
        {
            _gatewayService = new FakePayPalGatewayService();
        }

        [TestMethod]
        public async Task SendOrder_Check_Returned_Receipt()
        {
            var orderRequest = new OrderRequest(1, 1, 100, 2, "goods");

            var result = await _gatewayService.SendOrder(orderRequest);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }
    }
}