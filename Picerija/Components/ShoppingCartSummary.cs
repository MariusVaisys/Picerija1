using Microsoft.AspNetCore.Mvc;
using Picerija.Models;
using Picerija.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShopingCart _shopingCart;

        public ShoppingCartSummary(ShopingCart shoppingCart)
        {
            _shopingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shopingCart.GautiKrepselioPirkinius();
            _shopingCart.shoppingCartItems = items;

            var shopingCartViewModel = new ShoppingCartViewModel
            {
                ShopingCart = _shopingCart,
                ShopingCartTotal = _shopingCart.GautiKrepselioSuma()
            };
            return View(shopingCartViewModel);
               
        }
    }
}
