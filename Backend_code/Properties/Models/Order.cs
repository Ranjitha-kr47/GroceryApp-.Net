using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api_project.Properties.Models
{
    public class Order
    {

        [Key]
        public long id { get; set; }

        public string orderTrackingNumber { get; set; }

        public int totalQuantity { get; set; }

        public decimal totalPrice { get; set; }

        public string status { get; set; }

        public DateTime dateCreated { get; set; }
        public DateTime lastUpdated { get; set; }

        public HashSet<OrderItem> orderItems { get; set; } = new HashSet<OrderItem>();

        public Customer customer_ { get; set; }

        public Address shipping_Address_ { get; set; }
        public Address billing_Address_ { get; set; }

        public void add(OrderItem item)
        {

            if (item != null)
            {
                if (orderItems == null)
                {
                    orderItems = new HashSet<OrderItem>();
                }

                orderItems.Add(item);
                item.setOrder(this);
            }
        }

         public Customer getCustomer()
        {
            return customer_;
        }
        public void setCustomer(Customer customer)
        {
            this.customer_ = customer;
        }

        public String getOrderTrackingNumber()
        {
            return orderTrackingNumber;
        }

        public void setOrderTrackingNumber(String orderTrackingNumber)
        {
            this.orderTrackingNumber = orderTrackingNumber;
        }
        public Address getShippingAddress()
        {
            return shipping_Address_;
        }

        public void setShippingAddress(Address shippingAddress)
        {
            this.shipping_Address_ = shippingAddress;
        }

        public Address getBillingAddress()
        {
            return billing_Address_;
        }

        public void setBillingAddress(Address billingAddress)
        {
            this.billing_Address_ = billingAddress;
        }



    }
}