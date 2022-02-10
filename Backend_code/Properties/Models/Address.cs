using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class Address
    {
        [Key]
        public long id { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public string country { get; set; }

        public string zipCode { get; set; }
        // [NotMapped]
        // public Order order { get; set; }
    }
}