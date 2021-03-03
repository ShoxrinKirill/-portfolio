using Microsoft.AspNetCore.Mvc;
using _portfolio.Data.interfaces;
using System.Collections.Generic;
using _portfolio.ViewModels;

namespace _portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExamples _allExamples;
        private readonly IDiplomas _allDiplomas;

        public HomeController(IExamples iAllExamples) //, IDiplomas iAllDiplomas)
        {
            _allExamples = iAllExamples;
            //_allDiplomas = iAllDiplomas;
        }

        public ViewResult Resume()
        {
            return View();
        }

        public ViewResult Index()
        {
            PortfolioViewModels obj = new PortfolioViewModels();
            obj.allExamples = _allExamples.AllExamples;
            //obj.allDiplomas = _allDiplomas.AllDiplomas;
            return View(obj);
        }
    }
}