using System.Collections.Generic;

namespace Api_project.Properties.Models
{
    public class Purchase
    {
        public Customer customer { get; set; }
        public Address shippingAddress { get; set; }
        public Address billingAddress { get; set; }
        public Order order { get; set; }
        public HashSet<OrderItem> orderItems;

        public Customer getCustomer()
        {
            return customer;
        }
        public void setCustomer(Customer customer)
        {
            this.customer = customer;
        }
        public Address getShippingAddress()
        {
            return shippingAddress;
        }
        public void setShippingAddress(Address shippingAddress)
        {
            this.shippingAddress = shippingAddress;
        }
        public Address getBillingAddress()
        {
            return billingAddress;
        }
        public void setBillingAddress(Address billingAddress)
        {
            this.billingAddress = billingAddress;
        }
        public Order getOrder()
        {
            return order;
        }
        public void setOrder(Order order)
        {
            this.order = order;
        }
        public HashSet<OrderItem> getOrderItems()
        {
            return orderItems;
        }
        public void setOrderItems(HashSet<OrderItem> orderItems)
        {
            this.orderItems = orderItems;
        }
    }
}