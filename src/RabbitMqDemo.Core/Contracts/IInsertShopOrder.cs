namespace RabbitMqDemo.Core.Contracts
{
    public interface IInsertShopOrder
    {
        string CustomerName { get; }
        string CustomerFirstName { get; }
        //string[] OrderedProductIds { get; } 
    }
}
