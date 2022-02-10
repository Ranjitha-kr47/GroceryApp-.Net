namespace Api_project.Properties.Models
{
    public class PurchaseResponse
    {
        public string _orderTrackingNumber { get; set; }

        public PurchaseResponse(string orderTrackingNumber)
        {
            _orderTrackingNumber = orderTrackingNumber;
         }
    }
}