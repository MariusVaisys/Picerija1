using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class UzsakymasRepository : IUzsakymasRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShopingCart _shopingCart;

        public UzsakymasRepository(AppDbContext appDbContext, ShopingCart shopingCart)
        {
            _appDbContext = appDbContext;
            _shopingCart = shopingCart;
        }

        public void SukurtiUzsakyma(Uzsakymas uzsakymas)
        {
            uzsakymas.UzsakytaLaikas = DateTime.Now;
            _appDbContext.Uzsakymai.Add(uzsakymas);
            var shoppingCartItems = _shopingCart.shoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var uzsakymoInfo = new UzsakymoInfo()
                {
                    Kiekis = shoppingCartItem.Kiekis,
                    PicaId = shoppingCartItem.Pica.PicaId,
                    UzsakymoId = uzsakymas.UzsakymasId,
                    Kaina = shoppingCartItem.Pica.Kaina
                };

                _appDbContext.UzsakymoInfos.Add(uzsakymoInfo);
            }
            _appDbContext.SaveChanges();
        }
    }
}
