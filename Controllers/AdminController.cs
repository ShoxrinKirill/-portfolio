using Microsoft.AspNetCore.Mvc;

namespace _portfolio.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult adminpanel()
        {
            return View();
        }
    }
}