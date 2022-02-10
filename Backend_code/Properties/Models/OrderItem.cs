using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class OrderItem
    {
        [Key]
        public long id { get; set; }
        public string imageUrl { get; set; }
        private decimal unitPrice { get; set; }
        private int quantity { get; set; }
        private long productId { get; set; }
        public Order order { get; set; }

         public Order getOrder()
        {
            return order;
        }
        public void setOrder(Order order)
        {
            this.order = order;
        }
    }
}