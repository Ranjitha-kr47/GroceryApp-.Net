using Microsoft.AspNetCore.Mvc;
using Api_project.Properties.Models;
using System.Collections.Generic;
using System.Linq;

namespace Api_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private ApplicationContext _applicationContext;

        public ProductController(ApplicationContext context)
        {
            _applicationContext = context;
        }

        [HttpGet]
        [Route("product-category")]
        public ActionResult<IEnumerable<ProductCategory>> GetProductCategory()
        {
            return _applicationContext.productCategories.ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _applicationContext.product.ToList();
        }

        [HttpGet]
        [Route("findById/{id}")]
         public ActionResult<Product> GetByProductId(int id)
        {
            if (id <= 0)
            {
                return NotFound("Product id must be higher than zero");
            }

            List<Product> products = _applicationContext.product.Where(y => y.id == id).ToList<Product>();

            if (products == null)
            {
                return NotFound("product not found");
            }
            return Ok(products);
        }

        [HttpGet]
        [Route("findByCategoryId/{id}")]
        public ActionResult<Product> GetById(int id)
        {
            if (id <= 0)
            {
                return NotFound("Product id must be higher than zero");
            }

            List<Product> products = _applicationContext.product.Where(y => y.categoryid == id).ToList<Product>();

            if (products == null)
            {
                return NotFound("product not found");
            }
            return Ok(products);
        }

        [HttpGet]
        [Route("findByNameContaining/{name}")]
        public ActionResult<Product> GetByName(string name)
        {
            List<Product> products = _applicationContext.product.Where(y => y.name == name).ToList<Product>();

            if (products == null)
            {
                return NotFound("product not found");
            }
            return Ok(products);
        }

    }
}