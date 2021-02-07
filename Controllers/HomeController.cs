using Microsoft.AspNetCore.Mvc;

namespace _portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}