using Microsoft.AspNetCore.Mvc;

namespace BlazorServerAndMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("{page}")] // 👈 (1) これを追加
        public ActionResult Index()
        {
            return View("Views/Index.cshtml");
        }
    }
}
