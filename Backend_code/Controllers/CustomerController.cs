using Microsoft.AspNetCore.Mvc;
using Api_project.Properties.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : Controller
    {

        private ApplicationContext _applicationContext;

        public CustomerController(ApplicationContext context)
        {
            _applicationContext = context;
        }
        [HttpGet]
        [Route("findByEmail/{email}")]
        public ActionResult<Customer> GetByEmail(string email)
        {

            List<Customer> customers = _applicationContext.customers.Where(y => y.email == email).ToList<Customer>();

            if (customers == null)
            {
                return NotFound("product not found");
            }
            return Ok(customers);
        }

        [HttpPost]
        [Route("post")]
        public ActionResult Post([FromBody] Customer customer)
        {

            if (customer == null)
            {
                return NotFound("Customer data is not supplied");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _applicationContext.customers.AddAsync(customer);
            _applicationContext.SaveChangesAsync();
            return Ok(customer);
        }

    }
}