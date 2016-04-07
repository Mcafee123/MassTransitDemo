using System;

namespace MassTransitDemo.Web.Models
{
    public interface InsertShopOrderResult
    {
        string OrderId { get; }
        DateTime Timestamp { get; }
        short StatusCode { get; }
        string StatusText { get; }
    }
}
