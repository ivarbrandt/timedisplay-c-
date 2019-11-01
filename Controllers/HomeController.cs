using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace timedisplay.controllers
{
    public class HomeController: Controller
    {

        [HttpGet("/")]
        public ViewResult Index()
        {
            return View();
        }
    }
}