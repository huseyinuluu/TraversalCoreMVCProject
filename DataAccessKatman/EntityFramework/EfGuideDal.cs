using DataAccessKatman.Abstract;
using DataAccessKatman.Concrete;
using DataAccessKatman.Repository;
using EntityKatman.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatman.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToFalseByGuide(int id)
        {            
            var values = context.Guides.Find(id);
            values.Status = false;
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = true;
            context.SaveChanges();
        }
    }
}
