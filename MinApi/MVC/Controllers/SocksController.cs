using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    [Route("[controller]")]
    public class SocksController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            var data = SockDataSet.GetSocks();
            return View(data);
        }
        [Route("[action]")]
        public IActionResult GetByID(int id)
        {
            var data = SockDataSet.GetSocks().Where(x => x.Id == id).FirstOrDefault();
            return PartialView(data);
        }
        [Route("SearchByPrice/min/{minPrice:int}/max/{maxprice}")]
        public IActionResult SearchByPrice(int minPrice, int maxprice)
        {
            var data = SockDataSet.GetSocks().Where(x => x.Price >= minPrice && x.Price <= maxprice);
            return View("Index", data);

        }

    }
}
