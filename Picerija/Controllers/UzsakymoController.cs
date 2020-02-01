using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Picerija.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Picerija.Controllers
{
    [Authorize]
    public class UzsakymasController : Controller
    {
        private readonly IUzsakymasRepository _uzsakymasRepository;
        private readonly ShopingCart _shopingCart;

        public UzsakymasController(IUzsakymasRepository uzsakymasRepository, ShopingCart shopingCart)
        {
            _uzsakymasRepository = uzsakymasRepository;
            _shopingCart = shopingCart;
        }
        // GET: /<controller>/
        public IActionResult Moketi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Moketi(Uzsakymas uzsakymas)
        {
            var items = _shopingCart.GautiKrepselioPirkinius();
            _shopingCart.shoppingCartItems = items;

            if (_shopingCart.shoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Jusu pirkiniu krepselis tuscias, butu gerai jei pirma ka nors idetumet :)");
            }

            if (ModelState.IsValid)
            {
                _uzsakymasRepository.SukurtiUzsakyma(uzsakymas);
                _shopingCart.IsvalytiKrepseli();
                return RedirectToAction("BaigtasMokejimas");
            }
            return View(uzsakymas);
        }

        public IActionResult BaigtasMokejimas()
        {
            ViewBag.BaigtasMokejimasZinute = "Aciu kad uzsisaket, dabar greitai galesite megautis maistu";
            return View();
        }
    }
}
