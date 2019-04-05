using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PluralSightMVC_App.Models;
using PluralSightMVC_App.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PluralSightMVC_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethanyes Pie shop",
                Pies = _pieRepository.GetAllPies().OrderBy(x => x.Name).ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);

            if(pie==null)
            {
                return NotFound();
            }

            return View(pie);
        }
    }
}
