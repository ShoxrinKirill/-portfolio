using Microsoft.AspNetCore.Mvc;

namespace _portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Portfolio()
        {
            return View();
        }

        public ViewResult Rezume()
        {
            return View();
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}