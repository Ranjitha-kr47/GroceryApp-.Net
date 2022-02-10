using Microsoft.AspNetCore.Mvc;
using Api_project.Properties.Models;
using System.Collections.Generic;
using System.Linq;

namespace Api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private ApplicationContext _applicationContext;

        public CountryController(ApplicationContext context)
        {
            _applicationContext = context;
        }
        [HttpGet]
        [Route("countries")]
        public ActionResult<IEnumerable<Country>> GetCountry()
        {
            return _applicationContext.country.ToList();
        }

        [HttpGet]
        [Route("getbycountryid/{id}")]
        public ActionResult<State> GetByCountryId(int id)
        {
            if (id <= 0)
            {
                return NotFound("State id must be higher than zero");
            }

            List<State> states = _applicationContext.state.Where(x => x.countryid == id).ToList<State>();

            if (states == null)
            {
                return NotFound("department not found");
            }
            return Ok(states);
        }
    }
}