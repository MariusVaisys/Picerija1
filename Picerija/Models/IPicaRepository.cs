using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public interface IPicaRepository
    {
        IEnumerable<Pica> VisosPicos { get; }
        IEnumerable<Pica> AkcijinesPicos { get; }
        Pica GautiPicaById(int picaId);

    }
}
