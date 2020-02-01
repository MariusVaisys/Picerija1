using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class ShopingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShopingCartId { get; set; }

        public List<ShoppingCartItem> shoppingCartItems { get; set; }
        private ShopingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShopingCart GautiKrepseli(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShopingCart(context) { ShopingCartId = cartId };
        }

        public void IdetiIKrepseli(Pica pica, int amount)
        {
            var shoppingCartItem = 
                _appDbContext.ShoppingCartItems.SingleOrDefault(
                x => x.Pica.PicaId == pica.PicaId && x.ShoppingCartId == ShopingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShopingCartId,
                    Pica = pica,
                    Kiekis = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Kiekis++;
            }
            _appDbContext.SaveChanges();
        }

        public int PasalintiIsKrepselio(Pica pica)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                x => x.Pica.PicaId == pica.PicaId && x.ShoppingCartId == ShopingCartId);

            var localKiekis = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Kiekis > 1)
                {
                    shoppingCartItem.Kiekis--;
                    localKiekis = shoppingCartItem.Kiekis;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }

            }
            _appDbContext.SaveChanges();
            return localKiekis;
        }

        public List<ShoppingCartItem> GautiKrepselioPirkinius()
        {
            return shoppingCartItems ?? (shoppingCartItems =
                _appDbContext.ShoppingCartItems.Where(x => x.ShoppingCartId == ShopingCartId)
                .Include(x => x.Pica).ToList());

        }

        public void IsvalytiKrepseli()
        {
            var cartItems = _appDbContext.ShoppingCartItems
                .Where(krepselis => krepselis.ShoppingCartId == ShopingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GautiKrepselioSuma()
        {
            var total = _appDbContext.ShoppingCartItems.Where(x => x.ShoppingCartId == ShopingCartId)
                .Select(x => x.Pica.Kaina * x.Kiekis).Sum();
            return total;
        }

    }
}
