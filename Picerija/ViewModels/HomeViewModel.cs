using Picerija.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pica> Akcija { get; set; }
    }
}
