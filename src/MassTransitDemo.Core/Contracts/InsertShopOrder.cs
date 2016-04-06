namespace MassTransitDemo.Core.Contracts
{
    // ReSharper disable once InconsistentNaming
    public interface InsertShopOrder
    {
        string CustomerName { get; }
        string CustomerFirstName { get; }
        string[] OrderedProductIds { get; } 
    }
}
