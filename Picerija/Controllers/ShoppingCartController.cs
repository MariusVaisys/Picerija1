using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Picerija.Models;
using Picerija.ViewModels;

namespace Picerija.Controllers
{


    
    public class ShoppingCartController : Controller
    {
        private readonly IPicaRepository _picaRepository;
        private readonly ShopingCart _shopingCart;
        public ShoppingCartController(IPicaRepository picaRepository, ShopingCart shopingCart)
        {
            _picaRepository = picaRepository;
            _shopingCart = shopingCart;
        }

        public ViewResult Index()
        {
            var items = _shopingCart.GautiKrepselioPirkinius();
            _shopingCart.shoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShopingCart = _shopingCart,
                ShopingCartTotal = _shopingCart.GautiKrepselioSuma()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int picaId)
        {
            var pasirinktaPica = _picaRepository.VisosPicos.FirstOrDefault(x => x.PicaId == picaId);
            if (pasirinktaPica != null)
            {
                _shopingCart.IdetiIKrepseli(pasirinktaPica, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int picaId)
        {
            var pasirinktaPica = _picaRepository.VisosPicos.FirstOrDefault(x => x.PicaId == picaId);
            if (pasirinktaPica != null)
            {
                _shopingCart.PasalintiIsKrepselio(pasirinktaPica);
            }
            return RedirectToAction("Index");
        }
            
    }
}