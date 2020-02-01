using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Picerija.Models
{
    public class RusisRepository : IRusysRepository
    {
        private readonly AppDbContext _appDbContext;

        public RusisRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Rusis> VisosRusys => _appDbContext.Rusys;
    }
}
