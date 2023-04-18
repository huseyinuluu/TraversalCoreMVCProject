using DataAccessKatman.Abstract;
using DataAccessKatman.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatman.Repository
{
    public class GenericRepository<H> : IGenericDal<H> where H : class
    {
        public void Delete(H h)
        {
            using var c = new Context();
            c.Remove(h);
            c.SaveChanges();
        }

        public H GetByID(int id)
        {
            using var c = new Context();
            return c.Set<H>().Find(id);
        }

        public List<H> Getlist()
        {
            using var c = new Context();
            return c.Set<H>().ToList();
        }

        public List<H> GetListByFilter(Expression<Func<H, bool>> filter)
        {
            using var c = new Context();
            return c.Set<H>().Where(filter).ToList();
        }

        public void Insert(H h)
        {
            using var c = new Context();
            c.Add(h);
            c.SaveChanges();
        }

        public void Update(H h)
        {
            using var c = new Context();
            c.Update(h);
            c.SaveChanges();
        }
    }
}
