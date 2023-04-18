using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatman.Abstract
{
    public interface IGenericService<H>
    {
        void HAdd(H h);
        void HDelete(H h);
        void HUpdate(H h);
        List<H> HGetList();
        H HGetByID(int id);
        //List<H> GetByFilter(Expression<Func<H, bool>> filter);

    }
}
