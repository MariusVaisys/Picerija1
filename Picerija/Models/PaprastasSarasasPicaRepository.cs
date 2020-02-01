using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class PaprastasSarasasPicaRepository : IPicaRepository
    {
        private readonly IRusysRepository _rusysRepository = new PaprastaSarasasRusisRepository();
        public IEnumerable<Pica> VisosPicos => new List<Pica>
        {
            new Pica {PicaId = 1, Pavadinimas="Meksikietiska", Kaina=6.99M, Sudetis="A,B,C,D", Rusis = _rusysRepository.VisosRusys.ToList()[0], ImageUrl="", Pagaminta=true},
            new Pica {PicaId = 2, Pavadinimas="Acapulko", Kaina=5.99M, Sudetis="A,B,C,D", Rusis = _rusysRepository.VisosRusys.ToList()[1], ImageUrl="", Pagaminta=true},
            new Pica {PicaId = 3, Pavadinimas="Vulcano", Kaina=4.99M, Sudetis="A,B,C,D", Rusis = _rusysRepository.VisosRusys.ToList()[2], ImageUrl="", Pagaminta=true},
            new Pica {PicaId = 4, Pavadinimas="Cili", Kaina=7.99M, Sudetis="A,B,C,D", Rusis = _rusysRepository.VisosRusys.ToList()[1], ImageUrl="", Pagaminta=true},
        };

        public IEnumerable<Pica> AkcijinesPicos {get;}

        public Pica GautiPicaById(int picaId)
        {
            return VisosPicos.FirstOrDefault(x => x.PicaId == picaId);
        }
    }
}
