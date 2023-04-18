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
    public class EfVisitDal : GenericRepository<Visit>,
        IVisitDal
    {
        public List<Visit> GetListWithVisitByAppRoval(int id)
        {
            using (var context = new Context())
            {
                return context.Visits.Include(x => x.Destination).Where
                    (x => x.Status == "Onaylandı" && x.AppUserID == id).ToList();
            }
        }

        public List<Visit> GetListWithVisitByLast(int id)
        {
            using (var context = new Context())
            {
                return context.Visits.Include(x => x.Destination).Where
                    (x => x.Status == "Geçmiş Ziyaretler" && x.AppUserID == id).ToList();
            }
        }

        public List<Visit> GetListWithVisitByWaitAppRoval(int id)
        {
            using (var context = new Context())
            {
                return context.Visits.Include(x => x.Destination).Where
                    (x => x.Status == "Onay Bekliyor" && x.AppUserID == id ).ToList();
            }
        }
    }
}
