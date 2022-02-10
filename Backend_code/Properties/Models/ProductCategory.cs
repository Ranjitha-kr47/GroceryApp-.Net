using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class ProductCategory
    {
        [Key]
        public long id { get; set; }
        public string categoryName { get; set; }

        public List<Product> product { get; set; }
    }
}