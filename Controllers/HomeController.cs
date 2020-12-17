using Microsoft.AspNetCore.Mvc;

namespace BlazorServerAndMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View("Views/Index.cshtml");
        }
    }
}
