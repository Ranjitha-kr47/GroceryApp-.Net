using Api_project.Controllers;
using System.Collections.Generic;
using System.Diagnostics;
using System;


namespace Api_project.Properties.Models.Service
{
    public class CheckoutService:ICheckoutService
    {
    private readonly CustomerController _customerController;

    public CheckoutService(CustomerController customerController) {
        _customerController = customerController;
    }
  
    public PurchaseResponse placeOrder(Purchase purchase) {

        // retrieve the order info from dto
        Order order = purchase.getOrder();

        // generate tracking number
        string orderTrackingNumber = generateOrderTrackingNumber();
        order.setOrderTrackingNumber(orderTrackingNumber);

        // populate order with orderItems
        HashSet<OrderItem> orderItems = purchase.getOrderItems();
        foreach(var item in orderItems){
            item.order.add(item);
        }

        // populate order with billingAddress and shippingAddress
        order.setBillingAddress(purchase.getBillingAddress());
        order.setShippingAddress(purchase.getShippingAddress());

        // populate customer with order
        Customer customer = purchase.getCustomer();
        customer.add(order);

        // save to the database
        _customerController.Post(customer);

        // return a response
        return new PurchaseResponse(orderTrackingNumber);
    }

    private string generateOrderTrackingNumber() {

        // generate a random UUID number (UUID version-4)
        // For details see: https://en.wikipedia.org/wiki/Universally_unique_identifier
        //
        // return UUID.randomUUID().toString();
        Guid g = Guid.NewGuid();
        string myuuidAsString = g.ToString();
        return myuuidAsString;
    }
    }
}