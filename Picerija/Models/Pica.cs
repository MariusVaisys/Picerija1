using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class Pica
    {
        public int PicaId { get; set; }
        public string Pavadinimas { get; set; }
        public string Sudetis { get; set; }
        public string Alergenai { get; set; }
        public decimal Kaina { get; set; }
        public string ImageThumnailUrl { get; set; }
        public string ImageUrl { get; set; }
        public bool Akcija { get; set; }
        public bool Pagaminta { get; set; }
        public int RusisId { get; set; }
        public Rusis Rusis { get; set; }
    }
}
