using Microsoft.AspNetCore.Mvc;

namespace BlazorServerAndMVC.Controllers
{
    public class HomeController : Controller
    {
        //[Route("/")]
        //[Route("{*page}")] // 👈 (1) これを追加 → (4) ワイルドカード化し、すべての URL を捕捉してみる
        // 👆 (5) ワイルドカードルート定義は削除し、代わりに MVC コントローラへのフォールバック指定を Startup で追加
        public ActionResult Index()
        {
            return View("Views/Index.cshtml");
        }
    }
}
