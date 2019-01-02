using ArtigoDesignPattern.Singleton.Model;
using Microsoft.AspNetCore.Mvc;

namespace ArtigoDesignPattern.Singleton.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.GuidComum = new GuidComum().Instance;
            ViewBag.GuidSingleton = GuidSingleton.Instance;

            return View();
        }
    }
}
