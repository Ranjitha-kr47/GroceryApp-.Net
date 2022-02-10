using Microsoft.AspNetCore.Mvc;
using Api_project.Properties.Models;
using Api_project.Properties.Models.Service;
using System.Collections.Generic;
using System.Linq;

namespace Api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : Controller
    {
        private readonly CheckoutService _checkoutService;

        public CheckoutController(CheckoutService checkoutService)
        {
            _checkoutService = checkoutService;
        }
        [HttpPost]
        [Route("purchase")]
        public PurchaseResponse placeOrder([FromBody] Purchase purchase)
        {
            PurchaseResponse purchaseResponse = _checkoutService.placeOrder(purchase);
            return purchaseResponse;
        }
    }
}