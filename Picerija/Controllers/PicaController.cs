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
    public class PicaController : Controller
    {
        private readonly IPicaRepository _picaRepository;
        private readonly IRusysRepository _rusysRepository;
        public PicaController(IPicaRepository picaRepository, IRusysRepository rusysRepository)
        {
            _picaRepository = picaRepository;
            _rusysRepository = rusysRepository;
        }

        public ViewResult List()            //Action
        {
            PicaListViewModel picaListViewModel = new PicaListViewModel();
            picaListViewModel.Picos = _picaRepository.VisosPicos;

            picaListViewModel.PasirinktaRusis = "Astri";
            return View(picaListViewModel); //View to show
        }

        public IActionResult Detaliai(int id)
        {
            var pica = _picaRepository.GautiPicaById(id);
            if (pica == null)
            {
                return NotFound("Ne ten pataikete, nes cia nera");
            }
            return View(pica);
        }
    }
}
