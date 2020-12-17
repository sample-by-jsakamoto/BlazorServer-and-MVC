using Microsoft.AspNetCore.Mvc;

namespace BlazorServerAndMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("{*page}")] // 👈 (1) これを追加 → (4) ワイルドカード化し、すべての URL を捕捉してみる
        public ActionResult Index()
        {
            return View("Views/Index.cshtml");
        }
    }
}
