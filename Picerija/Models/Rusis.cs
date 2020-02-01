using System.Collections.Generic;

namespace Picerija.Models
{
    public class Rusis
    {
        public int RusisId { get; set; }
        public string RusisPavadinimas { get; set; }
        public string Aprasymas { get; set; }
        public List<Pica> Picos { get; set; }
    }
}