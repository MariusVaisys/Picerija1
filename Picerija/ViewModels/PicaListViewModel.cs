using Picerija.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.ViewModels
{
    public class PicaListViewModel
    {
        public IEnumerable<Pica> Picos { get; set; }
        public string PasirinktaRusis { get; set; }
    }
}
