using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Pica Pica { get; set; }
        public int Kiekis { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
