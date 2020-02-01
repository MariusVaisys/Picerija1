using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public interface IUzsakymasRepository
    {
        void SukurtiUzsakyma(Uzsakymas uzsakymas);
    }
}
