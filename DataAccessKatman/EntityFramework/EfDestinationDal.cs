using DataAccessKatman.Abstract;
using DataAccessKatman.Concrete;
using DataAccessKatman.Repository;
using EntityKatman.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatman.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public Destination GetDestinationWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations.Where(x=>x.DestinationID==id).Include(x => x.Guide).FirstOrDefault();
            }
        }
    }
}
