namespace Api_project.Properties.Models.Service
{
    public interface ICheckoutService
    {
        PurchaseResponse placeOrder(Purchase purchase);
    }
}