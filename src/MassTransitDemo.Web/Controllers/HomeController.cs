using System.Threading.Tasks;
using MassTransit;
using MassTransitDemo.Core;
using MassTransitDemo.Core.Contracts;
using MassTransitDemo.Web.Models;
using Microsoft.AspNet.Mvc;

namespace MassTransitDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}