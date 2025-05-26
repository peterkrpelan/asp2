using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class SocksController : Controller
    {
        public IActionResult Index()
        {
            var data = SockDataSet.GetSocks();
            return View(data);
        }
        public IActionResult GetByID(int id)
        {
            var data = SockDataSet.GetSocks().Where(x => x.Id == id).FirstOrDefault();
            return PartialView(data);
        } 
    }
}
