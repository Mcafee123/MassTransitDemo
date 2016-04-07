using MassTransitDemo.Core.Contracts;

namespace MassTransitDemo.Core
{
    public class InsertShopOrder: IInsertShopOrder
    {
        public string CustomerName { get; set; }
        public string CustomerFirstName { get; set; }
        //public string[] OrderedProductIds { get; set; }
    }
}
