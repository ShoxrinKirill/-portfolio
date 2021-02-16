using Microsoft.AspNetCore.Mvc;
using _portfolio.Data.interfaces;

namespace _portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExamples _allExamples;

        public HomeController(IExamples iAllExamples)
        {
            _allExamples = iAllExamples;
        }

        public ViewResult Rezume()
        {
            return View();
        }

        public ViewResult Index()
        {
            var examples = _allExamples.AllExamples;
            return View(examples);
        }
    }
}