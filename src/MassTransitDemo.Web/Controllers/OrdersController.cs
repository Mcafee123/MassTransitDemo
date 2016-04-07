using System.Threading.Tasks;
using MassTransit;
using MassTransitDemo.Core;
using Microsoft.AspNet.Mvc;

namespace MassTransitDemo.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IBus _bus;

        public OrdersController(IBus bus)
        {
            _bus = bus;
        }

        [HttpPost("api/orders")]
        public async Task<IActionResult> Post([FromBody]InsertShopOrder order)
        {
            await _bus.Publish(order);
            return Json(new {success = true});
        }

        [HttpGet("api/orders")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}