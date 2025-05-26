using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    [Route("ponozky")]
    [ApiController]
    public class APIController : ControllerBase
    {
        [Route("[action]/{id}")]
        public Socks? GetById(int id)
        {
            var data = SockDataSet.GetSocks().Where(x => x.Id == id).FirstOrDefault();
            return data;
        }
    }
}
