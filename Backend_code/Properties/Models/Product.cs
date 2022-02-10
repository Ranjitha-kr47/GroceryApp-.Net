using System;
using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{

    public class Product
    {
        [Key]
        public long id { get; set; }

        public string sku { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public decimal unit_Price { get; set; }

        public string image_Url { get; set; }

        public bool active { get; set; }

        public int units_In_Stock { get; set; }
        public DateTime date_created { get; set; }

        public DateTime? last_updated { get; set; }
        public int categoryid { get; set; }
        public ProductCategory category { get; set; }
    }
}