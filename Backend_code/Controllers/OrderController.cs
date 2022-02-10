using Microsoft.AspNetCore.Mvc;
using Api_project.Properties.Models;
using System.Collections.Generic;
using System.Linq;

namespace Api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private ApplicationContext _applicationContext;

        public OrderController(ApplicationContext context)
        {
            _applicationContext = context;
        }
        [HttpGet]
         public ActionResult<IEnumerable<Order>> GetOrdes()
        {
           return _applicationContext.orders.ToList();
        }
    }
}