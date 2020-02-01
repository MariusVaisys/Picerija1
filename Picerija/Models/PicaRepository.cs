using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class PicaRepository : IPicaRepository
    {
        private readonly AppDbContext _appDbContext;
        public PicaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pica> VisosPicos
        {
            get
            {
                return _appDbContext.Picos.Include(x => x.Rusis);
            }
        }

        public IEnumerable<Pica> AkcijinesPicos
        {
            get
            {
                return _appDbContext.Picos.Include(x => x.Rusis).Where(x => x.Akcija);
            }
            
        }

        public Pica GautiPicaById(int picaId)
        {
            return _appDbContext.Picos.FirstOrDefault(x => x.PicaId == picaId);
        }
    }
    
}
