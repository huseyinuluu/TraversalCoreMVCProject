using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessKatman.Abstract
{
    public interface IGenericDal<H>
    {
        void Insert(H h);
        void Delete(H h);
        void Update(H h);
        List<H> Getlist();
        H GetByID(int id);
        List<H> GetListByFilter(Expression<Func<H, bool>> filter);
    }
}
