using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class Customer
    {
        [Key]
        public long id { get; set; }
        public string firstName { get; set; }


        public string lastName { get; set; }

        public string email { get; set; }

        public HashSet<Order> orders { get; set; } = new HashSet<Order>();

        public void add(Order order) {

            if (order != null) {

                if (orders == null) {
                    orders = new HashSet<Order>();
                }

                orders.Add(order);
                order.setCustomer(this);
            }
        }

        
    }
}