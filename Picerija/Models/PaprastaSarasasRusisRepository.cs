using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class PaprastaSarasasRusisRepository : IRusysRepository
    {
        public IEnumerable<Rusis> VisosRusys => new List<Rusis>
        {
            new Rusis{RusisId=1, RusisPavadinimas="Astrios", Aprasymas="Su jelapenu ir pipirais"},
            new Rusis{RusisId=2, RusisPavadinimas="Vegetariskos", Aprasymas="Be mesos"},
            new Rusis{RusisId=1, RusisPavadinimas="Su daug mesos", Aprasymas="Su didesniu kiekiiu mesos"}
        };
    }
}
