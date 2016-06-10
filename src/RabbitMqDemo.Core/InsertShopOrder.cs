using RabbitMqDemo.Core.Contracts;

namespace RabbitMqDemo.Core
{
    public class InsertShopOrder: IInsertShopOrder
    {
        public string CustomerName { get; set; }
        public string CustomerFirstName { get; set; }
        //public string[] OrderedProductIds { get; set; }
    }
}
