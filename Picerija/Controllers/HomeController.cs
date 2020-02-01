using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Picerija.Models;
using Picerija.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Picerija.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPicaRepository _picaRepository;
        public HomeController(IPicaRepository picaRepository)
        {
            _picaRepository = picaRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Akcija = _picaRepository.AkcijinesPicos
            };
            return View(homeViewModel);
        }

       
    }
}
